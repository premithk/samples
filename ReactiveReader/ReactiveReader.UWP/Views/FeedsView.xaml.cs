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