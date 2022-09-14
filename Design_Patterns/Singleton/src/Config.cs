namespace Singleton;

// this could be a facade over a config file
public class Config
{
    #region Singleton access

    private static Config? _instance;

    public static Config Get()
    {
        if (_instance == null)
        {
            _instance = new Config(DateTime.Now);
        }

        return _instance;
    }

    #endregion

    public DateTime CreatedAt { get; }
    public string Format { get; set; }
    public string FormatMarker => "{_}";
    public TransformFlags Transforms { get; set; }

    private Config(DateTime createdAt)
    {
        CreatedAt = createdAt;
        Format = FormatMarker;
        Transforms = TransformFlags.None;
    }


    [Flags]
    public enum TransformFlags
    {
        None = 0,
        Uppercase = 1 << 0,
        Exclaim = 1 << 1,
        Aside = 1 << 2
    }
}