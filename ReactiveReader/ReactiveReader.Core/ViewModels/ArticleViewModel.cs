using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI.Fody.Helpers;

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
        [Reactive]
        public string Content { get; set; }
        [Reactive]
        public DateTimeOffset PublishDate { get; set; }
        [Reactive]
        public string Title { get; set; }
    }
}