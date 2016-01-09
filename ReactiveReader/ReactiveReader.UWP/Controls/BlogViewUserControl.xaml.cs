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

            this.WhenActivated(d =>
            {
                // behaviours

            });
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (BlogViewModel)value; }
        }

        public BlogViewModel ViewModel { get; set; }
    }
}