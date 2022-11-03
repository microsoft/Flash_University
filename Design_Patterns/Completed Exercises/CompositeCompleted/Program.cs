/*
 * This example showcases the Composite design pattern.
 *
 * ## Example
 *
 * This example is a simple file system, where files can be nested in folders recursively -
 * making it a tree-like structure (this is where the Composite pattern comes in). The CLI
 * has commands for navigating the file system (like cd), displaying info about the current item,
 * and adding/removing files & folders.
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