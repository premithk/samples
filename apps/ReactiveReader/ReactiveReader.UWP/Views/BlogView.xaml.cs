namespace ReactiveReader.UWP.Views
{
    using Core.ViewModels;
using ReactiveUI;
    using Windows.UI.Xaml;

    public sealed partial class BlogView : IViewFor<BlogViewModel>
{
        public BlogView()
        {
            this.InitializeComponent();
        }

        BlogViewModel BindingRoot => ViewModel;

        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel",
            typeof(BlogViewModel),
            typeof(BlogView),
            new PropertyMetadata(default(BlogViewModel)));
            
        public BlogViewModel ViewModel
        {
            get { return (BlogViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (BlogViewModel)value; }
        }
    }
}