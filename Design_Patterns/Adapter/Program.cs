/*
 * This example showcases the Adapter design pattern.
 *
 * ## Summary
 *
 * The Adapter design pattern adapts an existing class with some desired functionality
 * to match an interface that the application requires
 *
 * Here are the key pieces:
 *  - Client:
 *      the rest of the program that needs the desired functionality
 *  - Target:
 *      the interface the Client requires for the desired functionality
 *  - Adaptee:
 *      the existing class that contains some desired functionality
 *      (but doesn't match the Target interface)
 *  - Adapter:
 *      the class that uses the Adaptee to implement the Target interface
 *      (and fills out the required behavior if necessary)
 *
 * Notes:
 *  - The Adapter is responsible for formatting input/output data between
 *      the Target interface and Adaptee class
 *  - The Adapter pattern can also be used to add required behavior that
 *      is missing from the Adaptee class
 *
 * ## Example
 *
 *  - Cli (Cli.cs)
 *      The `Client` class
 *      It uses an ITransformer to perform text transformation
 *
 *  - ITransformer (Cli.cs)
 *      The `Target` interface
 *      Specifies the interface that the Cli requires
 *
 *  - TextManipulator (TextManipulator.cs)
 *      The `Adaptee` class
 *      Actually implements the text transformation/manipulation functionality,
 *      though it doesn't match ITransformer
 *
 *  - Transformer (Transformer.cs)
 *      The `Adapter` class
 *      Implements ITransformer and uses TextManipulator under the hood
 *      for the text transformation functionality
 */


using Adapter;

new Cli(new Transformer("")).Run();
