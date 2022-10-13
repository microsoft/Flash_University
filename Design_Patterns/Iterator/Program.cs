/*
 * This example showcases the Iterator design pattern.
 *
 * ## Summary
 *
 * The Adapter design pattern provides a way to access the elements of an
 * aggregate object sequentially without exposing its underlying representation.
 *
 * Here are the key pieces:
 *  - Iterator:
 *      an interface for accessing & traversing elements
 *  - ConcreteIterator:
 *      an implementation of the Iterator interface for a certain Aggregate
 *  - Aggregate:
 *      an interface with a method to get an Iterator
 *  - ConcreteAggregate:
 *      an implementation of the Aggregate that provides the correct ConcreteIterator instance
 *
 * Notes:
 *  - The Iterator interface at a minimum must provide some way to access the current element,
 *      some way to move to the next element, and some way to tell when it's done
 *
 * ## Example
 *
 *  - IIterator (Iterator.cs)
 *      The `Iterator` interface
 *      Only defines the basic iterator behavior
 *
 *  - IIterableCollection (Iterator.cs)
 *      The `Aggregate` interface
 *      Provides a method to create a new iterator
 *
 *  - LinkedList, LazyList, FibonacciSequence (LinkedList.cs, LazyList.cs, FibonacciSequence.cs)
 *      The `ConcreteAggregate` subclasses, each has a corresponding `ConcreteIterator`
 *
 *  - LinkedListIterator, LazyListIterator, FibonacciIterator (LinkedList.cs, LazyList.cs, FibonacciSequence.cs)
 *      The `ConcreteIterator` subclasses, each corresponds to a `ConcreteAggregate`
 */

using Iterator;

new Cli().Run();
