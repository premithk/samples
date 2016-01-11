using ReactiveUI;
using Splat;
using System;
using System.Reactive;

namespace OpenBrowser.Core.ViewModels
{
    public class OpenBrowserViewModel : ReactiveObject, IRoutableViewModel
    {
        private readonly IOpenBrowser _openBrowser;

        private string _websiteAddress;

        public OpenBrowserViewModel(IOpenBrowser openBrowser = null, IScreen hostScreen = null)
        {
            _openBrowser = openBrowser ?? Locator.Current.GetService<IOpenBrowser>();
            HostScreen = hostScreen ?? Locator.Current.GetService<IScreen>();

            var isValidWebsiteAddress = this.WhenAny(x => x.WebsiteAddress, x =>
            {
                Uri result;
                return Uri.TryCreate(WebsiteAddress, UriKind.Absolute, out result);
            });

            OpenWebPage = ReactiveCommand.CreateAsyncTask(isValidWebsiteAddress,
                async _ => { await _openBrowser.OpenDefaultBrowser(new Uri(WebsiteAddress)); });

            OpenWebPage.ThrownExceptions.Subscribe(
                ex => UserError.Throw("Does this device have a web browser installed?", ex));
        }

        public string WebsiteAddress
        {
            get { return _websiteAddress; }
            set { this.RaiseAndSetIfChanged(ref _websiteAddress, value); }
        }

        public ReactiveCommand<Unit> OpenWebPage { get; }

        public string UrlPathSegment => "OpenBrowser";

        public IScreen HostScreen { get; }
    }
}