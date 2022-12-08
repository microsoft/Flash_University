/*
 * This example showcases the Factory Method design pattern.
 *
 * ## Summary
 *
 * The Factory Method provides a way to separate the logic for picking
 * a subclass away from the code that is instantiating it.
 *
 * Here are the key pieces:
 *  - Product:
 *      the common interface for the object getting instantiated
 *  - ConcreteProduct:
 *      the concrete subclass implementing the Product interface
 *  - Creator:
 *      declares the abstract/virtual factory method, and calls it
 *      to create Product objects
 *  - ConcreteCreator:
 *      implements/overrides the factory method to return a ConcreteProduct
 *
 * ## Example
 *
 * This example is a simple number list "summarizer" - it generates a
 * list of numbers and calculates a summary (min, max, average, etc).
 * The way it generates the number list varies depending on which dataset
 * class is used.
 *
 *  - IDataset (Dataset/Dataset.cs)
 *      The `Product` interface
 *      Defines the shared interface for all of the various dataset classes
 *  - StaticDataset, etc (Dataset/Dataset.cs)
 *      The `ConcreteProduct` class
 *  - DatasetSummarizerBase (Dataset/DatasetSummarizer.cs)
 *      The `Creator` class
 *      Creates an IDataset and uses it
 *  - StaticDatasetSummarizer, etc (Dataset/DatasetSummarizer.cs)
 *      The `ConcreteCreator` class
 *      Implements the GetDataset factory method
 */

using Factory_Method;

new Cli().Run();