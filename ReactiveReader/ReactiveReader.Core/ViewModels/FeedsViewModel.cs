using System;
using System.Reactive;
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
        public FeedsViewModel()
        {
            Blogs = new ReactiveList<BlogViewModel>();

            Refresh = ReactiveCommand.CreateAsyncTask(async x =>
            {
                foreach (var blog in Blogs)
                {
                    blog.Refresh.InvokeCommand(null);
                }
            });

            Refresh.ThrownExceptions.Subscribe(thrownException => { this.Log().Error(thrownException); });

            Refresh.IsExecuting.ToProperty(this, x => x.IsLoading);
        }

        public ReactiveCommand<Unit> RemoveBlog { get; }
        public ReactiveCommand<Unit> AddBlog { get; }
        public ReactiveList<BlogViewModel> Blogs { get; set; }
        public ReactiveCommand<Unit> Refresh { get; }
        public bool IsLoading { get; private set; }
    }
}