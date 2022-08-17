/*
 * This example showcases the Template Method design pattern.
 *
 * ## Summary
 *
 * The Template Method pattern specifies the steps to a high-level
 * operation using abstract primitive operations, which are implemented
 * by subclasses in whatever way is applicable.
 *
 * Here are the key pieces:
 *  - Abstract Base Class:
 *      defines abstract primitive operations, and implements high-level operations using the primitive ones.
 *  - Concrete Subclasses:
 *      implements the primitive operations.
 *
 * Notes:
 *  - The high-level operation does not have to _only_ use the primitive operations.
 *  - The Abstract Base Class can also define "hooks" - virtual methods defined the base class that don't do anything by default
 *      These can be called in the high-level operations to allow subclasses to execute arbitrary code at specific points.
 *
 * ## Example
 *
 *  - FileSystem (FileSystem.cs)
 *      An abstract base class
 *      The high-level template methods are: ListFiles, CreateFile, GetFile, DeleteFile
 *      The primitive methods are: DoListFiles, DoMakeFile, DoCreateFile, DoRemoveFile
 *      The hooks are: BeforeRemoveFile
 *
 *  - File (FileSystem.cs)
 *      Another abstract base class
 *      The high-level template methods are: Append, Overwrite, GetContent
 *      The primitive methods are: DoRead, DoWrite
 *      The hooks are: OnRemove
 *
 *  - MemoryFileSystem (MemoryFileSystem.cs)
 *      A concrete subclass of FileSystem for an in-memory file system
 *      It implements the primitive methods, and also the hook BeforeRemoveFile
 *
 *  - MemoryFile (MemoryFileSystem.cs)
 *      A concrete subclass of File for in-memory files
 *      It implements the primitive methods, but doesn't implement any hooks
 *
 * The concrete subclasses in this example implement an in-memory file system
 * (the "files" are just entries in a dictionary)
 *
 * You could create another subclass (eg DiskFileSystem) that implements the primitive
 * operations to actually read/write to the OS file system on the hard drive.
 */

using Template_Method;

new Cli().Run();
