using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveReader.Core.ViewModels
{
    public interface IArticleViewModel
    {
        string Content { get; set; }
        DateTimeOffset PublishDate { get; set; }
        string Title { get; set; }
    }

    public class ArticleViewModel : ReactiveObject, IArticleViewModel
    {
        public string Content { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public string Title { get; set; }
    }
}