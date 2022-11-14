namespace Proxy.Library;

/*
 * TODO Additional Exercises: implement some other proxies with different functionality
 * Some examples:
 *
 *  - Permissions: Add a "password" property in the image data, and require that the
 *      user provide the image's password to see the image details.
 *
 *  - Result Caching: Add a "signature" property to Image that is calculated on-demand from
 *      the image's data (eg width + height + caption.length). Cache the calculated
 *      "signature" in the proxy so it doesn't need to be calculated every time.
 *
 *  - Logging Operation: Log whenever anything access the image's caption property.
 *
 *  - "Copy-on-Write": Add a resize/scale method on Image, and duplicate the image data
 *      whenever it's called (rather than mutating the underlying image data)
 */

/**
 * An Image proxy that only loads the actual image data when it's needed.
 *
 * Any access to the surface-level properties (see LazyImageProxy.Properties)
 * should not trigger the real image data to be loaded.
 */
public class LazyImageProxy : IImage
{
    internal LazyImageProxy(Properties properties)
    {
        Name = properties.Name;
        Width = properties.Width;
        Height = properties.Height;
    }

    private Image? _image;

    public string Name { get; }
    public int Width { get; }
    public int Height { get; }

    public string Caption
    {
        get
        {
            if (_image == null)
            {
                _image = new Image(Name);
            }

            return _image.Caption;
        }
    }


    #region "Surface-Level" Image Properties

    /**
     * The "surface-level" image properties that are saved
     * in the index and don't require loading the actual image data
     */
    internal class Properties
    {
        public Properties(ImageData data)
        {
            Name = data.Name;
            Width = data.Width;
            Height = data.Height;
        }

        public string Name { get; init; }
        public int Width { get; init; }
        public int Height { get; init; }
    }

    #endregion

}