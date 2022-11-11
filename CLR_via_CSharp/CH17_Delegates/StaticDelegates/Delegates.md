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
- System.Object --> System.Delegate-->System.MulticastDelegates
- Todo.Srikar --> draw out the diagram/difference of the image differences


## How did people make things simpler?
- If you noticed, in C, all you really ever needed to get a delegate or call back function to work was just the pointer/reference
- So delegates basically went through an evolution

```
button1.click += new EventHandler(button1_Click);
void button1_Click(object sender¿EventArgs e){
	//do something
}
```
- people would rather just write
```
button1.click += button1_Click;
void button1_Click(object sender¿EventArgs e){
	//do something
}
```

- What if you want to not not even write out a method?
- Just use a lambda function
## Glossary

## _target  
value that's passed in
## _methodPtr
internal integer the CLR uses to identify a method to be called back
## _invocationChaining 
array of delegates when building a delegate chain


### Callback

### Instance Method

### Static Method

### Delegate

### Pointer
