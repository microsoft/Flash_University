# Singleton Pattern

Ensure a class only has one instance, and provide a global point of access to it.

https://learning.oreilly.com/library/view/design-patterns-elements/0201633612/ch03.html#page_127


## Scenario

Sometimes there should only be one instance of a class, and the instance
should be easily accessible.

Often this is the case for classes that map to an underlying shared resource or device
(like a database, or possibly a file). This is especially applicable when the access
to the underlying resource needs to be carefully synchronised or monitored.


## Participants

### Objects

- `Singleton`: defines a static operation (aka `getInstance`) to access the
unique Singleton instance. The Singleon class is often (but not necessarily)
responsible for creating the unique instance.

### Interactions

- The `getInstance` static method should be the only way for other classes to
get access to a Singleton instance (the constructor(s) should be private).


## Consequences

### Benefits

The key benefit of this pattern is that you enforce that there is only one
instance of a class (and make that instance easily accessbile).

More specifically:

- the Singleton class has complete control over how other classes access
a Singleton instance

- still allows subclassing and behavior refinement

- the Singleton is instantiated on first use, not on application start

- can easily adapt this pattern to allow multiple instances without giving
up the control over access and instantiation


### Pitfalls

There are also a couple pitfalls to using this pattern:

- a Singleton is easy to create, but it's also very easy to overuse/misuse
(some people even consider "Singleton" to be an antipattern)

- the Singleton pattern can create highly-coupled designs

- Singleton's require careful design/implementation when being used in a
multi-threaded environment

- it's often difficult to unit test Singleton classes (especially when
working with mocks)
