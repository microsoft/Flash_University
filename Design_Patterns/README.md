# Design Patterns

The folder contains the notes and examples for all of the Design Patterns
that we'll go through in the CY22Q3 University of Flash course.

We will use the classic GoF Design Patterns book as the primary resource.
It is available online through the MS Library or on O'Reilly ([here](https://learning.oreilly.com/library/view/design-patterns-elements/0201633612/))

## What are Design Patterns?

Design Patterns are "typical solutions to commonly occurring problems in software design".

There are 4 main elements to a Design Pattern:
- **Pattern name**: description of the problem/solution (in a word or two).
- **Problem**: the situation the pattern applies to.
- **Solution**: the design to handle the problem.
- **Consequences**: results & trade-offs of using the pattern.

### Categorization

There are 3 categories of patterns:
- **Creational**: create objects for you (so you don't instantiate them directly)
- **Structural**: compose groups of objects into larger structures
- **Behavioral**: defines how objects interact/distribute responsibility

## Catalog

These are all the Design Patterns detailed in the GoF book. Not all of these have been implemented
in this repo yet (eventually, but still a work in progress).

### Creational

- **Abstract Factory**: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
- **Builder**: Separate the construction of a complex object from its representation so that the same construction process can create different representations.
- **Factory Method**: Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
- **Prototype**: Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
- **Singleton**: Ensure a class only has one instance, and provide a global point of access to it.

### Structural

- **Adapter**: Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn’t otherwise because of incompatible interfaces.
- **Bridge**: Decouple an abstraction from its implementation so that the two can vary independently.
- **Composite**: Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.
- **Decorator**: Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
- **Facade**: Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
- **Flyweight**: Use sharing to support large numbers of fine-grained objects efficiently.
- **Proxy**: Provide a surrogate or placeholder for another object to control access to it.


### Behavioral

- **Chain of Responsibility**: Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
- **Command**: Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
- **Interpreter**: Given a language, define a represention for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
- **Iterator**: Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
- **Mediator**: Define an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
- **Memento**: Without violating encapsulation, capture and externalize an object’s internal state so that the object can be restored to this state later.
- **Observer**: Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
- **State**: Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
- **Strategy**: Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
- **Template Method**: Define the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm’s structure.
- **Visitor**: Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.
