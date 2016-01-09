using ReactiveReader.Core.ViewModels;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ReactiveReader.UWP.Controls
{
    public sealed partial class ArticleUserControl : UserControl, IViewFor<ArticleViewModel>
    {
        public ArticleUserControl()
        {
            this.InitializeComponent();

            this.WhenActivated(d =>
            {
                // behaviours

                this.OneWayBind(ViewModel, viewModel => viewModel.Title, view => view.Title);

                // TODO DateTimeOffset converter to humainzer nuget.
                this.OneWayBind(ViewModel, viewModel => viewModel.Content, view => view.Content);
            });
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ArticleViewModel)value; }
        }

        public ArticleViewModel ViewModel { get; set; }
    }
}