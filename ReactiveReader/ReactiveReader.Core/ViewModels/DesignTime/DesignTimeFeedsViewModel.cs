using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveReader.Core.ViewModels.DesignTime
{
    public class DesignTimeFeedsViewModel : IFeedsViewModel
    {
        public DesignTimeFeedsViewModel()
        {
            Blogs = new ReactiveList<BlogViewModel>()
            {
                new BlogViewModel(new Uri("http://example.com/feed.rss")) {Title = "John Doe"},
                new BlogViewModel(new Uri("http://example.com/feed.rss")) {Title = "Jane Doe"},
            };
        }

        public ReactiveList<BlogViewModel> Blogs { get; set; }
    }
}