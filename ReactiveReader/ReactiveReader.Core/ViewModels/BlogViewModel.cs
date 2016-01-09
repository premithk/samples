using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Akavache;
using Conditions;
using ReactiveReader.Core.Services;
using ReactiveUI;
using Splat;

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

    public class BlogViewModel : ReactiveObject, IBlogViewModel
    {
        IFeedService FeedService { get; }
        IBlobCache Cache { get; }

        public BlogViewModel(string title, Uri feedAddress, IFeedService feedService = null, IBlobCache cache = null)
        {
            Title = title;
            FeedAddress = feedAddress;
            FeedService = feedService ?? Locator.Current.GetService<IFeedService>();
            Cache = cache ?? Locator.Current.GetService<IBlobCache>();

            Articles = new ReactiveList<ArticleViewModel>();

            Refresh = ReactiveCommand.CreateAsyncObservable(x => GetAndFetchLatestArticles());
            Refresh.Subscribe(articles =>
            {
                // this could be done cleaner, send a PR.
                // Refresh.ToPropertyEx(this, x => x.Articles);

                Articles.Clear();
                Articles.AddRange(articles);
            });

            
            Refresh.ThrownExceptions.Subscribe(thrownException => { this.Log().Error(thrownException); });
            _isLoading = Refresh.IsExecuting.ToProperty(this, x => x.IsLoading);

            // post-condition checks
            Condition.Ensures(FeedAddress).IsNotNull();
            Condition.Ensures(FeedService).IsNotNull();
            Condition.Ensures(Cache).IsNotNull();
        }

        public ReactiveCommand<List<ArticleViewModel>> Refresh { get; }

        public ReactiveList<ArticleViewModel> Articles { get; }

        Uri _feedAddress;
        public Uri FeedAddress
        {
            get { return _feedAddress; }
            private set { this.RaiseAndSetIfChanged(ref _feedAddress, value); }
        }

        readonly ObservableAsPropertyHelper<bool> _isLoading;
        public bool IsLoading
        {
            get { return _isLoading.Value; }
        }

        string _title;
        public string Title
        {
            get { return _title; }
            private set { this.RaiseAndSetIfChanged(ref _title, value); }
        }

        IObservable<List<ArticleViewModel>> GetAndFetchLatestArticles()
        {
            return Cache.GetAndFetchLatest(BlobCacheKeys.GetCacheKeyForFeedAddress(FeedAddress),
                async () => await Task.Run(() => FeedService.GetFeedFor(FeedAddress)),
                datetimeOffset => true, // store the results in the cache for 31 days.
                RxApp.MainThreadScheduler.Now + TimeSpan.FromDays(31));
        }
    }
}

