using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveReader.Core
{
    public static class BlobCacheKeys
    {
        public const string Feeds = "feeds";

        public static string GetCacheKeyForFeedAddress(Uri feedAddress) => $"feedAddress-{feedAddress.Host.ToLowerInvariant()}";
    }
}