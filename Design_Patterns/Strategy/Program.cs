/*
 * This example showcases the Strategy design pattern.
 *
 * ## Summary
 *
 * The Strategy pattern decouples an algorithm from its usage, allowing there
 * to be multiple algorithm implementations that can be plugged in at will.
 *
 * The algorithm implementations (aka algorithm family) can differ in various
 * ways, from performance tradeoffs, to the actual result produced.
 *
 * Here are the key pieces:
 *  - Strategy:
 *      the algorithm's interface
 *  - Concrete Strategy:
 *      the algorithm implementations that fulfill the interface
 *  - Context:
 *      the class that uses the algorithm
 *      it contains a reference to the Strategy interface, and the actual
 *      Concrete Strategy must be passed in from the outside
 *
 * ## Example
 *
 *  - IGuesserStrategy (NumberGuesser.cs)
 *      The `Strategy` interface
 *      Specifies the interface that the guesser strategies must fulfill
 *
 *  - BasicGuesser/RandomGuesser/BinarySearchGuesser (GuesserStrategies.cs)
 *      The `Concrete Strategy` classes
 *      Implements the guesser strategy interface, in various ways
 *
 *  - NumberGuesser (NumberGuesser.cs)
 *      The `Context` class
 *      Gets passed an IGuesserStrategy and uses it to make guesses
 *
 *  - Cli (Cli.cs)
 *      Picks a strategy based on user input and passes it to NumberGuesser
 */

using Strategy;

new Cli().Run();
