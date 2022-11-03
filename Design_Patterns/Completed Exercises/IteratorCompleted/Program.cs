/*
 * This example showcases the Iterator design pattern.
 *
 * ## Example
 *
 * This example is a simple CLI for printing out iterable data structures
 * (ie list-like things). The CLI generates a structure (usually with random values),
 * then uses an iterator to sequentially print all of its elements.
 *
 *  - IIterator (Iterator.cs)
 *      The `Iterator` interface
 *      Only defines the basic iterator behavior
 *
 *  - IIterableCollection (Iterator.cs)
 *      The `Aggregate` interface
 *      Provides a method to create a new iterator
 *
 *  - LinkedList, etc (LinkedList.cs, etc)
 *      The `ConcreteAggregate` subclasses, each has a corresponding `ConcreteIterator`
 *
 *  - LinkedListIterator, etc (LinkedList.cs, etc)
 *      The `ConcreteIterator` subclasses, each corresponds to a `ConcreteAggregate`
 */

using Iterator;

new Cli().Run();