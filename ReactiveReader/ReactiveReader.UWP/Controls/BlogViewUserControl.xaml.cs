using System;
using System.Reactive.Linq;
using ReactiveReader.Core.ViewModels;
using ReactiveUI;
using Windows.UI.Xaml.Controls;

namespace ReactiveReader.UWP.Controls
{
    public sealed partial class BlogViewUserControl : UserControl, IViewFor<BlogViewModel>
    {
        public BlogViewUserControl()
        {
            this.InitializeComponent();


            // behaviour
            
            // When the view is displayed to the user, automatically load data from cache/refresh latest.
            this.WhenAnyValue(view => view)
                .InvokeCommand(ViewModel, viewModel => viewModel.Refresh);
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (BlogViewModel)value; }
        }

        public BlogViewModel ViewModel { get; set; }
    }
}