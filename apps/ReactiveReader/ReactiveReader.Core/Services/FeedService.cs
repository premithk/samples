using ReactiveReader.Core.ViewModels;
using SimpleFeedReader;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace ReactiveReader.Core.Services
{
    public interface IFeedService
    {
        List<ArticleViewModel> GetFeedFor(Uri feedAddress);
    }

    public class FeedService : IFeedService
    {
        List<ArticleViewModel> IFeedService.GetFeedFor(Uri feedAddress)
        {
            var results = new List<ArticleViewModel>();

            var reader = new FeedReader(throwOnError: true);
            var articles = reader.RetrieveFeed(feedAddress.ToString());

            foreach (var article in articles)
            {
                results.Add(new ArticleViewModel()
                {
                    Title = article.Title,
                    Content = article.Title,
                    PublishDate = article.PublishDate
                });
            }

            return results;
        }
    }
}