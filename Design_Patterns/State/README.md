# State Pattern

Allows an object to alter its behavior when its internal
state changes, as if the object were changing classes.

https://learning.oreilly.com/library/view/design-patterns-elements/0201633612/ch05.html#page_305


## Scenario

Sometimes, you want an object to behave differently based
on its internal state - perhaps some operations are not
allowed in certain states, or it should just behave differently
when in some states.

This pattern works best when the object's states are finite
and clearly separable (think state machine).


## Participants

### Objects

- `State`: abstract class that defines the interface
for the state-specific behavior

- `ConcreteState`: concrete subclass of `State` that
implements the state-specific behavior

- `Context`: class that contains the state object and
calls into it for state-specific behavior

### Interactions

- `Context` delegates state-specific behavior to the `State` object

- A `Context` can pass itself to the `State` object; this lets the
`State` object access any field/method on the `Context`

- `Context` is the primary interface for clients - the `State` object
shouldn't have to be accessed directly. (One common exception - the
client may have to pass an instantiated `State` object into the
`Context` constructor)

- Either `Context` or `ConcreteState` can decide when it's time to
transition to a new state


## Benefits

The key benefit of the State pattern is that it clearly separates the
different states of the `Context`, and groups state-specific behavior together.

More specifically:

- it localizes state-specific behavior and partitions behavior for different states

- it makes state transitions explicit

- additionally, state objects can be shared (if they have no instance fields)
