using System;
using System.Collections.Generic;
using ReactiveUI;

namespace ReactiveReader.Core.ViewModels.DesignTime
{
    public class DesignTimeBlogViewModel : IBlogViewModel
    {
        public DesignTimeBlogViewModel()
        {
            Articles = new ReactiveList<ArticleViewModel>
            {
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                },
                new ArticleViewModel
                {
                    Content =
                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.",
                    Title =
                        "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishDate = DateTime.Now
                }
            };

            Title = "John Doe's Blog";
            FeedAddress = new Uri("http://example.com/atom.rss");
        }

        public ReactiveList<ArticleViewModel> Articles { get; set; }
        public Uri FeedAddress { get; set; }
        public bool IsLoading { get; set; }
        public ReactiveCommand<List<ArticleViewModel>> Refresh { get; set; }
        public string Title { get; set; }
    }
}