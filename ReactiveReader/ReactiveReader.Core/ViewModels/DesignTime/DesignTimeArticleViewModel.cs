using System;

namespace ReactiveReader.Core.ViewModels.DesignTime
{
    public class DesignTimeArticleViewModel : IArticleViewModel
    {
        public DesignTimeArticleViewModel()
        {
            Author = "John Doe";
            Body =
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc placerat metus sapien, sit amet vehicula tellus hendrerit a. Nunc euismod lorem vitae turpis vehicula, quis pharetra diam venenatis. Aliquam lacinia libero mauris, et dapibus velit pretium ac. Ut euismod sapien eu tellus euismod ullamcorper. In eget porta est. Nam ligula dui, placerat vel tincidunt non, tristique a enim. Etiam sit amet pulvinar neque. Proin ut orci quis neque porta sagittis.";
            Title =
                "Cras quis fermentum nisl. Vestibulum sed metus ut sapien commodo molestie ut id orci. Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            PostedAt = DateTime.Now;
        }

        public string Author { get; set; }
        public string Body { get; set; }
        public DateTime PostedAt { get; set; }
        public string Title { get; set; }
    }
}