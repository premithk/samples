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
        string Author { get; set; }
        string Body { get; set; }
        DateTime PostedAt { get; set; }
        string Title { get; set; }
    }

    public class ArticleViewModel : ReactiveObject, IArticleViewModel
    {
        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime PostedAt { get; set; }
        public string Title { get; set; }
    }
}