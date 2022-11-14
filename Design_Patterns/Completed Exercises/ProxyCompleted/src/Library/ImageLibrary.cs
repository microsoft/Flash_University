namespace Proxy.Library;

/**
 * The main interface the clients go through to retrieve images
 */
public class ImageLibrary
{
    public ImageLibrary()
    {
        _index = new LibraryIndex();
    }

    private LibraryIndex _index;

    public List<string> GetImageNames()
    {
        return _index.Images.Keys.ToList();
    }

    public IImage GetImage(string name)
    {
        var properties = _index.Images[name];
        return new LazyImageProxy(properties);
    }
}

/**
 * A list of all stored images and some surface-level properties (width, height)
 *
 * In a real world scenario, this would be persisted somewhere that was easy/quick
 * to load, separate from the actual image data. For simplicity's sake, in this
 * example we derive the image properties from the actual image data in ImageStore.
 */
internal class LibraryIndex
{
    public LibraryIndex()
    {
        Images = new Dictionary<string, LazyImageProxy.Properties>();

        // generally, these image properties would be retrieved from
        // a separate location (that's more easily accessible)
        // but for simplicity's sake, here we're pulling straight
        // from the ImageStore saved image data
        foreach (var image in ImageStore.Images)
        {
            Images.Add(image.Name, new LazyImageProxy.Properties(image));
        }
    }

    public readonly Dictionary<string, LazyImageProxy.Properties> Images;
}
