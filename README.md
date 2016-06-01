![Logo](Art/Logo150x150.png "Logo")

# Genesis.Analytics

[![Build status](https://ci.appveyor.com/api/projects/status/fso56h66pnjda222?svg=true)](https://ci.appveyor.com/project/kentcb/genesis-analytics)

## What?

> All Genesis.* projects are formalizations of small pieces of functionality I find myself copying from project to project. Some are small to the point of triviality, but are time-savers nonetheless. They have a particular focus on performance with respect to mobile development, but are certainly applicable outside this domain.
 
**Genesis.Analytics** is a simple abstraction that application authors can consume to provide analytics in their mobile applications. Alongside this abstraction are implementations for various analytics providers (currently only Raygun is supported). The abstraction is delivered as a PCL targetting a wide range of platforms, including:

* .NET 4.5
* Windows 8
* Windows Store
* Windows Phone 8
* Xamarin iOS
* Xamarin Android

## Why?

I was sick of dragging this code from project to project. I just want to install a package and be done with it. Why not just use the provider directly? I've already had to switch providers several times in different projects, and am abstraction makes this far easier to achieve.

## Where?

The easiest way to get **Genesis.Analytics** is via [NuGet](http://www.nuget.org/packages/Genesis.Analytics/):

```PowerShell
Install-Package Genesis.Analytics
```

## How?

**Genesis.Analytics** is super simple to use. Consuming code should depend on `IAnalyticsService`:

```C#
public class SomeViewModel
{
    public SomeViewModel(IAnalyticsService analyticsService)
    {
        analyticsService.Track("some vm created");
    }
}
```

You can record exceptions, identify users, and track events. The `IAnalyticsService` passed in by your DI can be either the `NullAnalyticsService` provided by the `Genesis.Analytics` package, or a provider specific implementation such as `RaygunAnalyticsService`.

Note that you still need to initialize your provider on application startup according to that provider's documentation.

## Who?

**Genesis.Analytics** is created and maintained by [Kent Boogaart](http://kent-boogaart.com). Issues and pull requests are welcome.