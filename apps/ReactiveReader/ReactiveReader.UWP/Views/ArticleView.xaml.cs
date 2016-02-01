using Windows.UI.Xaml;
using ReactiveReader.Core.ViewModels;

namespace ReactiveReader.UWP.Views
{
    public sealed partial class ArticleView
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel",
            typeof (ArticleViewModel),
            typeof (ArticleView),
            new PropertyMetadata(default(ArticleViewModel)));

        public ArticleView()
        {
            InitializeComponent();
        }

        private ArticleViewModel BindingRoot => ViewModel;

        public ArticleViewModel ViewModel
        {
            get { return (ArticleViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
    }
}