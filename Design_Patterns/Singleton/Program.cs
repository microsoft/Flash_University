/*
 * This example showcases the Singleton design pattern.
 *
 * ## Summary
 *
 * The Singleton design pattern ensures a class only ever has one instance,
 * and provides a global point of access to it.
 *
 * Here are the key pieces:
 *  - Singleton:
 *      hides its constructor, and provides a static method to access the
 *      unique instance of the Singleton
 *
 * Notes:
 *  - The static method should be the only way for other classes to
 *      get access to a Singleton instance
 *  - The pattern can be adapted to allow any number of instances
 *      (one instance is by far the most common configuration).
 *      The key part is that the Singleton class controls how other classes
 *      can access a Singleton instance
 *
 * ## Example
 *
 *  - Config (Config.cs)
 *      The `Singleton` class
 *      It only ever instantiates a single instance, and only allows that
 *      instance to be accessed through the `Get` static method
 *
 *  - ConfigEditor (ConfigEditor.cs)
 *      Uses the Config singleton
 *      ConfigEditor gets the Config instance on construction and reuses
 *      it across all methods
 *
 *  - TextTransformer (TextTransformer.cs)
 *      Uses the Config singleton
 *      TextTransformer gets a Config instance on the fly whenever it needs it
 */

using Singleton;

new Cli().Run();