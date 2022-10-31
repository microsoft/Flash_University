/*
 * This example showcases the Composite design pattern.
 *
 * ## Summary
 *
 * The Composite design pattern provides a way to have a uniform interface
 * for both individual objects and composite (aka grouped) objects as part
 * of a tree-like hierarchy.
 *
 * Here are the key pieces:
 *  - Component:
 *      the common interface/abstract class for Leafs and Composites
 *  - Leaf:
 *      a primitive object that cannot contain children
 *  - Composite:
 *      an object that contains Components as children (eg a group of Components)
 *
 * Notes:
 *  - There can be multiple Leaf classes (and multiple Composite classes)
 *
 * ## Example
 *
 * This example is a simple file system, where files can be nested in folders recursively -
 * making it a tree-like structure (this is where the Composite pattern comes in).
 *
 *  - Item (FileSystem\Item.cs)
 *      The `Component` abstract class
 *      Defines the interface shared between files & folders
 *
 *  - File (FileSystem\File.cs)
 *      A `Leaf` subclasses, representing a file
 *
 *  - Folder (FileSystem\Folder.cs)
 *      A `Composite` subclasses, representing a folder
 */

using Composite;

new Cli().Run();