using System;
using System.Reactive;
using System.Reactive.Linq;
using Akavache;
using Conditions;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using Splat;

namespace ReactiveReader.Core.ViewModels
{
    public interface IFeedsViewModel
    {
        ReactiveCommand<Unit> RemoveBlog { get; }
        ReactiveCommand<Unit> AddBlog { get; }
        ReactiveCommand<Unit> PersistData { get; }
        ReactiveList<BlogViewModel> Blogs { get; }
        ReactiveCommand<Unit> RefreshAll { get; }
        bool IsLoading { get; }
    }

    public class FeedsViewModel : ReactiveObject, IFeedsViewModel, IEnableLogger
    {
        private readonly IBlobCache Cache;

        public FeedsViewModel(IBlobCache cache = null)
        {
            Cache = cache ?? Locator.Current.GetService<IBlobCache>();

            Cache.GetOrCreateObject(BlobCacheKeys.Blogs, () => new ReactiveList<BlogViewModel>())
                .Subscribe(blogs => { Blogs = blogs; });

            RefreshAll = ReactiveCommand.CreateAsyncTask(async x =>
            {
                foreach (var blog in Blogs)
                {
                    blog.Refresh.InvokeCommand(null);
                }
            });

            RefreshAll.ThrownExceptions.Subscribe(thrownException => { this.Log().Error(thrownException); });

            RefreshAll.IsExecuting.ToProperty(this, x => x.IsLoading);

            PersistData =
                ReactiveCommand.CreateAsyncTask(async x => { await Cache.InsertObject(BlobCacheKeys.Blogs, Blogs); });

            PersistData.ThrownExceptions.Subscribe(thrownException => { this.Log().Error(thrownException); });

            // behaviours

            // when a blog is added or removed, wait for 5 seconds of inactivity before persisting the data as the user may be doing bulk [add|remove] operations.
            this.WhenAnyValue(viewModel => viewModel.Blogs)
                .Throttle(TimeSpan.FromSeconds(5), RxApp.MainThreadScheduler)
                .InvokeCommand(this, viewModel => viewModel.PersistData);

            // When an user adds a new blog to the feed, automatically fetch/cache the contents of the blog.
            this.WhenAnyObservable(viewModel => viewModel.Blogs.ItemsAdded)
                .Subscribe(x => x.Refresh.InvokeCommand(null));

            // post-condition checks
            Condition.Ensures(Cache).IsNotNull();
            Condition.Ensures(RefreshAll).IsNotNull();
            Condition.Ensures(PersistData).IsNotNull();
        }

        public ReactiveCommand<Unit> RemoveBlog { get; private set; }
        public ReactiveCommand<Unit> AddBlog { get; private set; }
        public ReactiveCommand<Unit> PersistData { get; private set;  }
        public ReactiveList<BlogViewModel> Blogs { get; private set; }
        public ReactiveCommand<Unit> RefreshAll { get; private set; }
        [Reactive]
        public bool IsLoading { get; private set; }
    }
}