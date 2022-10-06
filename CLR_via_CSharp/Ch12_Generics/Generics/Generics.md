# Generics

## Previous questions

Fundamentally, we want to be able to reuse code and use optimized structures/objects for our programming.

*Generics* are a mechinism that provides algorithm reuse

Let's look at the list of functionality/optimized algorithms in Systems.Collections.Generic

## Goals
* As usual, Jeffrey got a little carried away with specifics.
* Focus on what is a generic
* how is it used
* why we should use them/not be afraid of using classes that use them
* How they look in the CLR

## Basics --> what is a 'generic'/what does it look like

	List<T>

The T is a type parameter and takes in any Type

Naming conventions: naming guidleines for generic parameters 'TName'

	public class WriteBufferedPageSortedDictionary<TKey, TValue> : ExplicitBeginWriteBufferedSortedDictionary<TKey, TValue>
		where TKey : IComparable<TKey>

So we Definitely use them. Next step, should we use them.

## Motivation for why they exist

* Performance (See code example)
* Algorithm Preservation

## Perf Example
* How to force an object to be GC'd
* how to keep track of GC cycles
* Keep track of time w/ examples
* Why is there really no performance loss on reference types while a huge loss in value types?
## System.Array is the base class for all array types

## Open and Closed Example
* Let's look at when we think the 'code will work'
* Some ideas, try catch as a way to figure out/debug code
    * We do the exact same thing with kill switches
* backticks -> ` followed by number arity 
* Open vs closed types in Ildasm

## Generic Types and Inheritance
* See Example

But more importantly, understand CLR optimizations--> regardless of separate assembly, the CLR considers all reference type arguments to be identical

## Do we think C# and the CLR support generic interfaces?
* IEnumerator, IDisposable etc.
## Generic Delegates exist

### Vocabulary for the faint of heart

Arity - number of type parameters required by a type

Constraints - 

Type Objects - internal data structures for every type used by an application

Open Type - Type with something undefined

Closed Type - Type where actual data is passed in for all of the type arguments

Code Explosion - Same as before --> but basically for every type/method combo, you'll get all of the IL

Invariant - Generic type parameter can't be changed

Contravariant - can be changed from a class to a derived class -- look for 'in' --> only in input

Covariant -can change from one clas sot a base class (only in output)