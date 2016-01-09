namespace ReactiveReader.UWP
{
    using ReactiveUI;
using Windows.UI.Xaml.Navigation;
    using Core.ViewModels;

    public sealed partial class AppShell : IScreen
    {
        public AppShell()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;

            Router.Navigate.Execute(new FeedsViewModel());
        }

        public RoutingState Router { get; } = new RoutingState();
    }
}
