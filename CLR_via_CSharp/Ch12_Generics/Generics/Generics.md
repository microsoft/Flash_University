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
