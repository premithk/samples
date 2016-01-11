using OpenBrowser.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace OpenBrowser.UWP
{
    public sealed partial class AppShell : Page
    {
        public AppShell()
        {
            InitializeComponent();

            NavigationCacheMode = NavigationCacheMode.Required;

            AppBootstrapper = new AppBootstrapper();
        }

        public AppBootstrapper AppBootstrapper { get; private set; }
    }
}