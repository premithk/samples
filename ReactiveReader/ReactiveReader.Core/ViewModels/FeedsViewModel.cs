using System;
using System.Reactive;
using System.Reactive.Linq;
using Akavache;
using ReactiveUI;
using Splat;

namespace ReactiveReader.Core.ViewModels
{
    public interface IFeedsViewModel
    {
        ReactiveCommand<Unit> RemoveBlog { get; }
        ReactiveCommand<Unit> AddBlog { get; }
        ReactiveList<BlogViewModel> Blogs { get; }
        ReactiveCommand<Unit> Refresh { get; }
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

            Refresh = ReactiveCommand.CreateAsyncTask(async x =>
            {
                foreach (var blog in Blogs)
                {
                    blog.Refresh.InvokeCommand(null);
                }
            });

            Refresh.ThrownExceptions.Subscribe(thrownException => { this.Log().Error(thrownException); });

            Refresh.IsExecuting.ToProperty(this, x => x.IsLoading);


            // behaviours

            // when a blog is added or removed, wait for 5 seconds of inactivity before persisting the data as the user may be doing bulk [add|remove] operations.
            this.WhenAnyValue(viewModel => viewModel.Blogs)
                .Throttle(TimeSpan.FromSeconds(5), RxApp.MainThreadScheduler)
                .Subscribe(x => { Cache.InsertObject(BlobCacheKeys.Blogs, Blogs); });
        }

        public ReactiveCommand<Unit> RemoveBlog { get; }
        public ReactiveCommand<Unit> AddBlog { get; }
        public ReactiveList<BlogViewModel> Blogs { get; set; }
        public ReactiveCommand<Unit> Refresh { get; }
        public bool IsLoading { get; private set; }
    }
}