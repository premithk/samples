using OpenBrowser.Core.ViewModels;
using ReactiveUI;

namespace OpenBrowser.Core
{
    public class AppBootstrapper
    {
        public AppBootstrapper(RoutingState testRouter = null)
        {
            Router = testRouter ?? new RoutingState();
            Router.Navigate.Execute(new OpenBrowserViewModel());
        }

        public RoutingState Router { get; protected set; }
    }
}