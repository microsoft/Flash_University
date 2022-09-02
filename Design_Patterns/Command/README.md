# Command Pattern

The command pattern encapsulates requests/operations into an object that can be
passed around, stored, and invoked by something with no knowledge of what the command does.

https://learning.oreilly.com/library/view/design-patterns-elements/0201633612/ch05.html#page_233


## Scenario

Sometimes, an object needs to initiate a request/execute an operation, but the object
doesn't need to know anything about the operation itself. Or sometimes you need to
be able to package an operation up and not execute it until later.


## Participants

- **Base Command:** the base abstract command class (or interface).
At minimum, it must contain a way to execute the command

- **Concrete Command:** a concrete command class.
Implements the execution method to perform a specific request/operation.
Usually takes a Receiver in its constructor, and invokes methods on it.

- **Receiver:** an object that actually implements the operations.
Commands generally will be bound to a Receiver, and invoke the receiver's methods

- **Invoker:** an object that invokes the commands.
The Invoker knows nothing about what the commands do, it just invokes the execution method.


## Benefits

The key benefits to the Command pattern is that it packages operations/requests into
an object that can be passed around, stored, and invoked without knowing what the
operations are or what the do.

This allows you to do things like the following:

- Pass a command as a parameter to something that execute it later.
(Eg a UI Button can be passed a command on creation, and execute it when clicked)

- Store/Queue requests. (Commands do not have to executed immediately, or at all)

- Support undoing operations.
(The base command must have an undo/unexecute method)

- Log/record operations that are applied.
(For auditing, or for reapplying operations after a system crash)

- Compose basic operations together to make more complex operations.
(Commands can be used as the basis of transactions)
