# CLSS.ExtensionMethods.IList.GetRandom

### Problem

Getting a random element from a list is usually done in this way:

```csharp
var rng = new System.Random();
var chosenElement = list[rng.Next(0, list.Count)];
```

### Solution

With this package, the above segment can now be written as:

```csharp
using CLSS;

var chosenElement = list.GetRandom();
```

Internally, this package uses and depends on the `Constants.DefaultRandom` package in CLSS to save on the allocation of a new `System.Random` instance.

Optionally, `GetRandom` also takes in a `System.Random` of your choosing in case you want a custom-seeded random number generator:

```csharp
using CLSS;

var chosenElement = list.GetRandom(customrng);
```

If you are on .NET 6, you can pass in [`System.Random.Shared`](https://docs.microsoft.com/en-us/dotnet/api/system.random.shared).

**Note**: `GetRandom` works on all types implementing the [`IList<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1) interface, *including raw C# array*.

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).