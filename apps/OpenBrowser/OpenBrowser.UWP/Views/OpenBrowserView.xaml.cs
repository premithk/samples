using OpenBrowser.Core.ViewModels;
using ReactiveUI;
using Windows.UI.Xaml;

namespace OpenBrowser.UWP.Views
{
    public sealed partial class OpenBrowserView : IViewFor<OpenBrowserViewModel>
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel",
            typeof(OpenBrowserViewModel),
            typeof(OpenBrowserView),
            new PropertyMetadata(default(OpenBrowserViewModel)));

        public OpenBrowserView()
        {
            InitializeComponent();

            this.WhenActivated(d =>
            {
                //
            });
        }

        private OpenBrowserViewModel BindingRoot => ViewModel;

        public OpenBrowserViewModel ViewModel
        {
            get { return (OpenBrowserViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (OpenBrowserViewModel)value; }
        }
    }
}