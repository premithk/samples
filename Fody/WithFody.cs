using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Reactive;

namespace CleanViewModels
{
    public class WithFody : ReactiveObject, IBlogViewModel
    {
        public ReactiveList<string> Articles { get; }

        [Reactive]
        public Uri FeedAddress { get; }

        [ObservableAsProperty]
        public extern bool IsLoading { get; }

        public ReactiveCommand<Unit> Refresh { get; }

        [ObservableAsProperty]
        public extern string Title { get; }
    }
}
