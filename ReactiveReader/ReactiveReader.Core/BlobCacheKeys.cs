using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveReader.Core
{
    public class BlobCacheKeys
    {
        public string Feeds => "feeds";

        public string GetCacheKeyForFeedAddress(Uri feedAddress) => $"feedAddress-{feedAddress.Host.ToLowerInvariant()}";
    }
}