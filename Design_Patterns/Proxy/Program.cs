/*
 * This example showcases the Proxy design pattern.
 *
 * ## Summary
 *
 * The Proxy pattern Provides a placeholder for another object to control access to the
 * original object, allowing you to tweak the behavior of the original object.
 *
 * Here are the key pieces:
 *  - Subject:
 *      the common interface for the Proxy and the RealSubject;
 *      this is what all clients interact with
 *  - RealSubject:
 *      the real object that the proxy represents
 *  - Proxy:
 *      the stand-in for the real object;
 *      implements peripheral behavior, and delegates core behavior to the RealSubject
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