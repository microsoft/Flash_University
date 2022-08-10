using Command;

/*
 * This example showcases the Command design pattern.
 *
 * ## Summary
 *
 * The command pattern encapsulates requests/operations into an object
 * that can be passed around, stored, and invoked by something with no
 * knowledge of what the command does.
 *
 * There are a couple key pieces:
 *  - Base Command: the base abstract command class (or interface)
 *      At minimum, it must contain a way to execute the command
 *  - Concrete Command: a concrete command class
 *      Implements the execution method to perform a specific request/operation.
 *      Usually takes a Receiver in its constructor, and invokes methods on it.
 *  - Receiver: an object that actually implements the operations
 *      Commands generally will be bound to a Receiver, and invoke the receiver's methods
 *  - Invoker: an object that invokes the commands
 *      The Invoker knows nothing about what the commands do, it just invokes the execution method.
 *
 * ## Example
 *
 * Here are the different components in this example:
 *  - Command (Command.cs)
 *      the abstract Command class
 *  - Counter (Counter.cs)
 *      the "receiver" for the counter commands (ie what the commands act on)
 *  - Increment/Decrement/etc (Counter.cs)
 *      some concrete commands that operate on Counter
 *  - Help (CommandRunner.cs)
 *      an additional command that doesn't use Counter
 *  - CommandRunner (CommandRunner.cs)
 *      the "invoker" (ie what executes the commands)
 *  - CounterCli (CounterCli.cs)
 *      the system that puts everything together
 */
var counterCli = new CounterCli();

counterCli.Run();
