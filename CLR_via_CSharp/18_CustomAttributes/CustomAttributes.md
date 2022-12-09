# Custom Attributes
## Goals
- Understand What Custom Attributes Are
- How to create them
- What they look like in a CLR
- Attribute Trivia
- Detection
- Conditional Attribute Classes 

## What are custom attributes
We have seen Attributes before. 
<details>
  <summary>Can you think of some examples?</summary>
  - Bit Flags
  - Serializable
</details>

Jeffrey goes into a few different definitions of an attribute.

```
If you could create something that assigns properties like 'static', 'private' and 'public' do, that would be an attribute
```
> Case in point, let's just look at what happens if we have "public"

> Look at w/ and w/out serializable

1. An attribute is nothing more than "an instance of a class."

2. An attribute is a "logical state container." That is, it should be like an indication system.

3. think of custom attributes as instances of classes that have been serialized to a bytestream that reside in metadata.

We have seen Attributes before. 

```C#

[TestClass]
public TestClass{
    [TestMethod]
    public void TestMethod(){

    }
}
```
<details>
  <summary>If we're the computer, what an we use these for?</summary>
  We can go through the methods/classes and only pick ones that match our "attribute" and then do functions on them.
</details>



## Let's build our own -- of course, Chess Pieces


## Guess The Answers
```C#
[Flags][Flags]
```
<details>
  <summary>Answer</summary>
  Duplicate flags error
</details>

Are there limitations on what you can add attributes to?
<details>
  <summary>Answer</summary>
  Not really. Unless you specify them directly, there's no limitations
</details>

Have we seen an example of an attribute across assemblies?

<details>
  <summary>Answer</summary>
  [assembly: InternalsVisibleTo("AssemblyB")]
</details>

What is the difference between these:

```C#
[Serializable] [Flags]
[Serializable, Flags]
[SerializableAttribute, FlagsAttribute]
[SerializableAttribute()] [FlagsAttribute()]
```

<details>
  <summary>Answer</summary>
  None. They all the same
</details>


What is the default inheritance value
<details>
  <summary>Answer</summary>
  True
</details>

What do you think this does?

```C#
#define VERIFY
#define Test
[Conditional("Test")][Conditional("Verify")]

public sealed class SomeAttribute:Attribute{}

[Some]
Something
```

## I am not covering the matching and detetcting without creating beceause they seem rather obscure
