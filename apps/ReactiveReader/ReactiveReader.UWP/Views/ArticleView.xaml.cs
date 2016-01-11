namespace ReactiveReader.UWP.Views
{
    using Core.ViewModels;
using ReactiveUI;
using Windows.UI.Xaml;

    public sealed partial class ArticleView : IViewFor<ArticleViewModel>
{
        public ArticleView()
        {
            this.InitializeComponent();
        }

        ArticleViewModel BindingRoot => ViewModel;

        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel",
            typeof(ArticleViewModel),
            typeof(ArticleView),
            new PropertyMetadata(default(ArticleViewModel)));

        public ArticleViewModel ViewModel
            {
            get { return (ArticleViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ArticleViewModel)value; }
        }
    }
}