using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akavache;
using ReactiveReader.Core.Services;
using ReactiveUI;
using Splat;

namespace ReactiveReader.Core
{
    public class AppBootstrapper : IEnableLogger
    {

        public AppBootstrapper()
        {
            ConfigureAkavache();
            RegisterDependencies();
            }

        public void ConfigureAkavache()
        {
            BlobCache.ApplicationName = "ReactiveReaderApp";
            BlobCache.EnsureInitialized();

            Locator.CurrentMutable.RegisterConstant(BlobCache.UserAccount, typeof(IBlobCache));
            Locator.CurrentMutable.RegisterConstant(BlobCache.Secure, typeof(ISecureBlobCache));
        }
        public void RegisterDependencies()
        {
            Locator.CurrentMutable.RegisterConstant(new FeedService(), typeof(IFeedService));
        }

    }

}