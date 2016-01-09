using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akavache;
using Conditions;
using ReactiveReader.Core.Services;

namespace ReactiveReader.Core.ViewModels
{
    public interface IBlogViewModel
    {
        ReactiveList<ArticleViewModel> Articles { get; }
        Uri FeedAddress { get; }
        bool IsLoading { get; }
        ReactiveCommand<List<ArticleViewModel>> Refresh { get; }
        string Title { get; }
    }

    public class BlogViewModel : ReactiveObject, IBlogViewModel, IEnableLogger
    {
        private readonly IFeedService FeedService;
        private readonly IBlobCache Cache;

        public BlogViewModel(string title, Uri feedAddress, IFeedService feedService = null, IBlobCache cache = null)
        {
            Title = title;
            FeedAddress = feedAddress;
            FeedService = feedService ?? Locator.Current.GetService<IFeedService>();
            Cache = cache ?? Locator.Current.GetService<IBlobCache>();

            Articles = new ReactiveList<ArticleViewModel>();

            Refresh = ReactiveCommand.CreateAsyncObservable(x => GetAndFetchLatestArticles());


            Refresh.ThrownExceptions.Subscribe(thrownException => { this.Log().Error(thrownException); });
            Refresh.IsExecuting.ToProperty(this, x => x.IsLoading);

            // post-condition checks
            Condition.Ensures(FeedAddress).IsNotNull();
            Condition.Ensures(FeedService).IsNotNull();
            Condition.Ensures(Cache).IsNotNull();
        }

        public ReactiveList<ArticleViewModel> Articles { get; private set; }

        public Uri FeedAddress { get; private set; }

        public bool IsLoading { get; private set; }

        public ReactiveCommand<List<ArticleViewModel>> Refresh { get; private set; }

        public string Title { get; private set; }

        private IObservable<List<ArticleViewModel>>  GetAndFetchLatestArticles()
        {
            return Cache.GetAndFetchLatest(BlobCacheKeys.GetCacheKeyForFeedAddress(FeedAddress),
                async () => await Task.Run(() => FeedService.GetFeedFor(FeedAddress)),
                datetimeOffset => true, // store the results in the cache for 31 days.
                RxApp.MainThreadScheduler.Now + TimeSpan.FromDays(31));
        }
    }
}

