# Samples

* https://github.com/reactiveui/ReactiveUI/issues/687
* https://github.com/reactiveui/ReactiveUI.Samples

Our samples are a work in progress, see the above issues to see if someone in the community has already contributed examples, if you still can't find what you need open a github issue to request a specific implementation example.

As a rule of thumb when contributing, the samples should cater for our three target markets:
   
    a) Know's ReactiveUI, doesn't know the direct platform (iOS|Android|Mac|UWP)
    b) Know's their direct platform (iOS|Android|Mac|UWP) but doesn't know ReactiveUI.
    c) Brand new to everything, doesn't know much yet.

## Architectural Patterns
* [AOP using Fody](https://github.com/reactiveui/samples/tree/master/patterns/Fody)
* Dependency Injection via Splat
* [Dependency Injection via Composition Root](https://github.com/kentcb/WorkoutWotch/search?utf8=%E2%9C%93&q=composition)
* Routing View-First
* Routing ViewModel-First
* Logging using Splat
* User Interaction
* Data persistence in VM (Suspension / Resume)
* [HTTP Rest Client](https://github.com/paulcbetts/refit)
* [HTTP Request Request Limiting, Auto-deduplication, Request Prioritization and Speculative requests](https://github.com/paulcbetts/fusillade)
* [Cross-platform user settings](https://github.com/flagbug/Lager)
* [Cross-platform cache and user data persistence](https://github.com/akavache/Akavache)

## General features
* Events
* Converting data in binding

## Platform-specific
### Xamarin iOS
* Master Detail Navigation
* Custom tableview elements
* ReactiveTableView example (should demonstrate `ReactiveTableViewSource`, adding/removing rows, all the good stuff that kent fixed in #820, #927)
* Notifications
* Push notifications
* Backgrounding
* Deep AppLinks

### Xamarin Android
* Fragments
* Backbutton handling.
* Notifications
* Push notifications
* Backgrounding
* Deep AppLinks


### Xamarin Forms

### Universal Windows Platform
* [Design Time / Blend](https://github.com/reactiveui/samples/tree/master/apps/ReactiveReader)
* Backbutton handling.
* Pinned Tiles
* Toasts
* Deep AppLinks
* Correct binding avoiding leaks

_User Interface:_
* [Pivot](https://github.com/reactiveui/samples/tree/master/apps/ReactiveReader)

### WPF
* Correct binding avoiding leaks

### Xamarin Mac
* No examples planned for this platform until we start getting github issues opened imho.


