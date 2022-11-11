# Delegates

## Questions from last time
```C#
a = Array.CreateInstance(typeof(string), new[] { 0, 0 }, new[] { 1, 1 });
Console.WriteLine(a.GetType());
```

## Goals
- Understand what delegates are
- How they work under the hood
- Be able to "track the function along"
- See how they have evolved (delegate --> anonymous functions --> func and action)

## First look at call backs
- Fundamentally, everything is storedin a location on memory and is either stored in memory or if a pointer to something else.
- C used pointers to achieve this --> basically pass in a memory location and be able to do something with it.
- That functionality in C# is called a delegate and comes with a few bonus features, namely type safety.


## The best way to understand this is simply to walk through an example.
- starting off with a 'static method'. Simple because it's outside of a class
- Code flow logically goes 1 step at a time but when the delegate is called, we basically call the delegate's function before continuing

## How does this work at the IL Level?
- A delegate creates 4 methods: ctor, invoke, beginInvoke, and EndInvoke
- These are outdated but it's worth looking at just to get a picture of what things look like
- System.Object --> System.Delegate-->System.MulticastDelegate
- 
## Glossary

### Callback

### Instance Method

### Static Method

### Delegate

### Pointer
