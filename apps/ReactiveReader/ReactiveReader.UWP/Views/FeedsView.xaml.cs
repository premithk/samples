using Windows.UI.Xaml;
using ReactiveReader.Core.ViewModels;

namespace ReactiveReader.UWP.Views
{
    public sealed partial class FeedsView
    {
        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel",
            typeof (FeedsViewModel),
            typeof (FeedsView),
            new PropertyMetadata(default(FeedsViewModel)));

        public FeedsView()
        {
            InitializeComponent();
        }

        private FeedsViewModel BindingRoot => ViewModel;

        public FeedsViewModel ViewModel
        {
            get { return (FeedsViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }
    }
}