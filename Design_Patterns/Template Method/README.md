# Template Method Pattern

Defines the steps of an algorithm/operation, and lets
subclasses override the underlying basic operations.


## Scenario

Sometimes, you want to allow subclasses to refine/implement
some basic/primitive operations of an object, but also want
to provide higher-level operations in the super class so
the subclasses don't have to (or can't) implement the
main operations.

(This can also be done a little more explicitly with composition,
but leaks some implmentation details)


## Participants

### Objects

- `AbstractClass`: base class that defines abstract primitive operations,
and implements high-level operations using the primitive ones.

- `ConcreteClass`: subclass that implmenets the primitive operations.

### Interactions

- `ConcreteClass` relies on `AbstractClass` to implement the operation invariants

- Template methods can call any of these methods:
    - operations implemented in the `ConcreteClass`
    - operations implemented in `AbstractClass`
    - methods on other classes
    - "hook" methods

A **"hook"** method is a method defined in the `AbstractClass` that allows subclasses
to execute arbitrary code at predefined points. They are usually named `BeforeX`,
`OnX`, or `AfterX`. Their default implementation in the `AbstractClass` does nothing,
and it's optional for the subclasses to override.


## Benefits

The key benefit to the template method pattern is that it
provides high-level main operations, but still allows
subclasses to implement behavior that is specific to their need.

This leads to several things:

- The subclasses don't have to implement every high-level operation

- The superclass can enforce the steps that the high-level operations take

- More generally, the superclass can enforce where subclass logic is only allowed to execute
