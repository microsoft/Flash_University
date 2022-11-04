# Chapter 16: Arrays

## Questions from last time

- Still have not answered the question re: auto properties in delegates (might get to it next time in chapter called "
  Delegates"

## Goals for today:

- How arrays work for day to day use (hopefully review)
- How array work under the hood (can you say Ildasm?)
- Arrays of value vs reference types
- Array special properties/abilities
- How to remove all knowledge and understanding of humanity with arrays starting at 1
- Arrays, Arrays of Arrays, Jagged arrays
- fixed size vs unsafe arrays

## Intro

At a high level, arrays are just an ordered grouping of a singular type. Some basic things to consider. In example
one, "SimpleArray.cs", we basically start with the basic array instantiation.

```C#
int[] fibonacci;
fibonacci = new int[10];
```

<details>
  <summary>What is the keyword here? Based off what we know, are arrays reference or value types?</summary>

    So it has to be a reference type. It is a reference to the array object

</details>

<details>
  <summary>Are there any limitations to the type we put in?</summary>

    As long as every type has a type of 

</details>


<details>
  <summary>What are the initial values of the array</summary>

    Based on previous chapter, we 0 out all bits upon allocation so 0

</details>

So arrays can definitely work with Value types. First question we should ask is "what happens with reference types"

Well, if we create a simple array of some reference class:

```C#
var references = new UsefulClass[10];
```

<details>
  <summary>What are the initial values of the array</summary>

    At this point, they're just references. They are uninstnatinated pointers/references that must point to objects of type mentioned

</details>

//TODO.Srikar (draw out figure 16.1)

Where can we see the differences? Of course, the IL?

```il
IL_0000: ldc.i4.s     
IL_0002: newarr
IL_0007: stloc.0      
```

```il
IL_0028: ldc.i4.2
IL_0029: newarr       
IL_002e: stloc.1      
```

Is there really a difference? Not really... This kind of reinforces the point that arrays of reference types are not
actually instantiated.

These are Single dimensional, Zero-based arrays. AKA As per god, please do this whenever possible]

We'll see certain IL instructions that reference them but for now, just remember the first one

```
newwarr, ldelem, ldelema, ldlen, stelem
```

<details>
  <summary>Is there any regulation on the size of the array if it's placed in an array?</summary>

    No. Which is why they're called jagged

</details>

## Initialization

What is the difference between the following

```
String[] values = new String[];

//code that sets values
```

and

```
String[] values = new String[]{"one", "two"}
```

## Casting

The fundamental points here are that 
- the CLR allows you to cast an array from one type to another if a conaverstion exists
- the array must be a reference type

(begs the question, why not value types?)

You can get the same effect with Array.Copy

### Array.Copy()
- See examples, really the best. Basically, we can cast from one array type to another, even value types

## All Arrays are System.Array

- you get a lot out of the box. Just look at [System.Array](https://learn.microsoft.com/en-us/dotnet/api/system.array?view=net-7.0)
- you get IEnumerable, ICollection and IList implicitly
- there is some magic going on here as these interfaces are only defeinted for vectors
## Glossary:

array covariance - the functionality of being able to convert from one type of array to another

array initializer - the {} after an array with the initial values

SZ arrays - Single Dimensional, zero degree arrays AKA vectors

Jagged Arrays - Arrays of arrays

dup - duplicates current item on the stack

