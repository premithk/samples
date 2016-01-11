namespace ReactiveReader.UWP.Views
{
    using Core.ViewModels;
using ReactiveUI;
    using Windows.UI.Xaml;

    public sealed partial class FeedsView : IViewFor<FeedsViewModel>
    {
        public FeedsView()
        {
            this.InitializeComponent();
        }

        FeedsViewModel BindingRoot => ViewModel;

        public static readonly DependencyProperty ViewModelProperty = DependencyProperty.Register(
            "ViewModel",
            typeof(FeedsViewModel),
            typeof(FeedsView),
            new PropertyMetadata(default(FeedsViewModel)));

        public FeedsViewModel ViewModel
            {
            get { return (FeedsViewModel) GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (FeedsViewModel) value; }
        }
    }
}