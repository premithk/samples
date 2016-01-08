using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveReader.Core.ViewModels
{
    public interface IBlogViewModel
    {
        ReactiveList<ArticleViewModel> Articles { get; }
        Uri FeedAddress { get; }
        bool IsLoading { get; }
        ReactiveCommand<ArticleViewModel> Refresh { get; }
        string Title { get; }
    }

    public class BlogViewModel : ReactiveObject, IBlogViewModel, IEnableLogger
    {
        public BlogViewModel(Uri feedAddress)
        {
            FeedAddress = feedAddress;
        }

        public ReactiveList<ArticleViewModel> Articles { get; private set; }

        public Uri FeedAddress
        {
            get; private set;
        }

        public bool IsLoading { get; private set; }

        public ReactiveCommand<ArticleViewModel> Refresh
        {
            get; private set;
        }

        public string Title
        {
            get; set;
        }
    }
}