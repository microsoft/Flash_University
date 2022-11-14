/*
 * This example showcases the Proxy design pattern.
 *
 * ## Example
 *
 * This example is a simple image viewer cli; you can list the images present,
 * and see details of the image (you can't actually view it - that's too much work)
 *
 *  - IImage (Library/Image.cs)
 *      The `Subject` interface
 *      Defines the interface shared between the Image and the ImageProxy
 *  - Image (Library/Image.cs)
 *      The `RealSubject` class
 *  - ImageProxy (Library/ImageProxy.cs)
 *      The `Proxy` class
 *
 * There are two other classes that are only tangentially related to the Proxy pattern,
 * but are important for this example:
 *
 *  - ImageLibrary (Library/ImageLibrary.cs)
 *      The manager object that clients go through to get IImage instances.
 *      This class can return whatever IImage implementation it wants (either a real Image,
 *      or a proxy) and it doesn't impact clients.
 *  - ImageStore (Library/ImageStore.cs)
 *      The class that loads the actual image data - in reality this class would be
 *      doing something resource intensive, like loading the data from disk (this example
 *      pretends by sleeping the thread)
 *
 */

using Proxy;

new Cli().Run();