namespace Proxy.Library;

/*
 * TODO Main Exercise: create a "Subject" interface for Image
 */

public class Image
{
    internal Image(string name)
    {
        _data = ImageStore.LoadImage(name);
    }

    private readonly ImageData _data;

    #region Public Properties

    public string Name => _data.Name;
    public int Width => _data.Width;
    public int Height => _data.Height;
    public string Caption => _data.Caption;
    
    #endregion
}

