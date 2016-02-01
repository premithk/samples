using Windows.UI.Xaml;
using ReactiveReader.Core.ViewModels;

namespace ReactiveReader.UWP.Views
{
    public sealed partial class BlogView
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel",
            typeof (BlogViewModel),
            typeof (BlogView),
            new PropertyMetadata(default(BlogViewModel)));

        public BlogView()
        {
            InitializeComponent();
        }

        private BlogViewModel BindingRoot => ViewModel;

        public BlogViewModel ViewModel
        {
            get { return (BlogViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
    }
}