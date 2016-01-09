using System;
using Windows.UI.Xaml.Controls;
using ReactiveReader.Core.ViewModels;
using ReactiveUI;

namespace ReactiveReader.UWP.Views
{
    public sealed partial class FeedsView : Page, IViewFor<FeedsViewModel>
    {
        public FeedsView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                // behaviours

                // When a user adds a new blog to the feed, automatically fetch/cache the contents of the blog.
                this.WhenAnyObservable(x => x.ViewModel.Blogs.ItemsAdded)
                    .Subscribe(x => x.Refresh.InvokeCommand(null));
            });
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (FeedsViewModel) value; }
        }

        public FeedsViewModel ViewModel { get; set; }
    }
}