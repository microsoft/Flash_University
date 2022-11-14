namespace Proxy.Library;

public interface IImage
{
    public string Name { get; }
    public int Width { get; }
    public int Height { get; }
    public string Caption { get; }
}

public class Image : IImage
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

