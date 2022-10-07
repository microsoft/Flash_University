# Generics

## Previous questions
* Can you auto-implemented event property (need a little longer on this one)

Fundamentally, we want to be able to reuse code and use optimized structures/objects for our programming.

*Generics* are a mechanism that provides algorithm reuse

Let's look at the list of functionality/optimized algorithms in Systems.Collections.Generic

## Goals
* As usual, Jeffrey got a little carried away with specifics.
* Focus on what is a generic
* How are they used
* What it might look like in our code base (PSD)
* why we should use them/not be afraid of using classes that use them
* How they look in the CLR
* What is a constraint and what problem do they solve


## Basics --> what is a 'generic'/what does it look like

	List<T>

The T is a type parameter and takes in any Type

Naming conventions: naming guidleines for generic parameters 'TName'

	public class WriteBufferedPageSortedDictionary<TKey, TValue> : ExplicitBeginWriteBufferedSortedDictionary<TKey, TValue>
		where TKey : IComparable<TKey>

So we definitely use them. Next step, should we use them.

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

## Generic Type Identity
don't do what's int he example
## Delegate and Interface variance
	public delegate TResult Func<in T, out TResult>(T arg);

in = contra-variant

out = covariant

invariant--> everything else

	Func<Object, ArgumentException> fn1 = null;

	Func<String, Exception> fn2 = fn1;

	Func<String, Execption> fn2 = fn1;
	Exception e = fn2("");

I really don't understand this?

Per Jeff, we are basically casting fn1 into fn2. fn1 takes in object and returns an arg exception, fn2 takes in a string and returns and exception


So because we have in and out, the compiler is able to say that the in (in this case String in f2) can be compiled b/c it is a derived class of Object (contravariant) and the out can be a broader type of exception or the covariant


## How do Generics work with methods?
They allow for multiple different types of arguments in a method. Jeff uses swap

## Constraints

General rule is that they limit things on a type

1. Primary constraints
    * Type Parameter gets 0 or 1 primary constraint. It's an unsealed, nonspecial reference type
	
2. Secondary Constraints
    * Type Parameter gets 0 or moresecondary constraints where constraints represent interfaces
	* There exists a 'parameter constraint which we will say exists and if you encounter it, you can writ to me how angry you were that we didn't cover it

3. Constructor constraints
    * Type Parameter gets 0 or 1 constructor constraints
	* can't be a struct
#### Guess which one is which
	private static List ConstraintOne<T, TBase> (IList<T> list) where T: IRobot
	internal sealed class ConstraintTwo<T> where T: Stream{}
	internal sealed class ConstraintThree<T> where T: new(){}

* There is special behaviors for null and struct/class etc. but that's well beyond my scope
### Vocabulary for the faint of heart

Arity - number of type parameters required by a type

Constraints - Fundamentally, a way to guarantee type safety and operability inside of a function while using generics/verify what's going in is operable

Type Objects - internal data structures for every type used by an application

Open Type - Type with something undefined

Closed Type - Type where actual data is passed in for all of the type arguments

Code Explosion - Same as before --> but basically for every type/method combo, you'll get all of the IL

Invariant - Generic type parameter can't be changed

Contravariant - can be changed from a class to a derived class -- look for 'in' --> only in input

Covariant -can change from one clas sot a base class (only in output)

### Other links
Best answer to Ref vs out
https://stackoverflow.com/questions/16196940/whats-the-difference-between-ref-vs-out-parameter