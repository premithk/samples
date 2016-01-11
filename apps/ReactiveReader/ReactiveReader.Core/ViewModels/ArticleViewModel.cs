using System;
using ReactiveUI;

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
        string _content;
        public string Content
        {
            get { return _content; }
            set { this.RaiseAndSetIfChanged(ref _content, value); }
        }

        DateTimeOffset _publishDate;
        public DateTimeOffset PublishDate
        {
            get { return _publishDate; }
            set { this.RaiseAndSetIfChanged(ref _publishDate, value); }
        }

        string _title;
        public string Title
        {
            get { return _title; }
            set { this.RaiseAndSetIfChanged(ref _title, value); }
        }
    }
}