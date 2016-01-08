using ReactiveReader.Core.ViewModels;
using ReactiveUI;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ReactiveReader.UWP.Controls
{
    public sealed partial class BlogViewUserControl : UserControl, IViewFor<BlogViewModel>
    {
        public BlogViewUserControl()
        {
            this.InitializeComponent();
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (BlogViewModel)value; }
        }

        public BlogViewModel ViewModel { get; set; }
    }
}