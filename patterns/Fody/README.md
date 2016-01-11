# Introduction
[Fody](https://github.com/Fody/Fody) is a open-source plugin which is commonly used to "weave" at compilation time simple public properties into complex implementations which allows for cleaner viewmodel and prevents common implementation errors (private/public assignment) from occurring.

[Kirk Woll maintains a Fody weaver](https://github.com/kswoll/ReactiveUI.Fody) (plugin) that will automatically convert properties that have been annotated with `[Reactive]` into `INotifyPropertyChanged` and `[ObservableAsProperty]` into `ObservableAsPropertyHelper`.


## Before 
	public class MyCoolViewModel : ReactiveObject
	{
		private readonly ObservableAsPropertyHelper<bool> _isLoading;
		public bool IsLoading
		{
		    get { return _isLoading.Value; }
		} 
	}

## After

	public class MyCoolViewModel : ReactiveObject
	{
	    [ObservableAsProperty]
	    public extern bool IsLoading { get; }
	}

# Resources
* [https://github.com/Fody/Fody](https://github.com/Fody/Fody)
* [https://github.com/kswoll/ReactiveUI.Fody](https://github.com/kswoll/ReactiveUI.Fody)
* [https://ghuntley.com/archive/2016/01/07/debugging-a-fody-weaver-plugin-and-or-debugging-msbuild/](https://ghuntley.com/archive/2016/01/07/debugging-a-fody-weaver-plugin-and-or-debugging-msbuild/)
