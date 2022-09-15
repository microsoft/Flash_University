namespace Singleton;

/**
 * The interface to the application config
 *
 * This is the "Singleton"
 *
 * There should only be a single application config used in the
 * application, and everything should be able to access it -
 * hence why where are using the Singleton pattern here.
 *
 * In this example, everything is in memory, but this
 * could easily be updated to read/write to a config file.
 */
public class Config
{
    #region Singleton access

    /*
     * This is the single, unique Config instance
     *
     * The single instance is not created immediately -
     * it's created the first time someone requests it
     */
    private static Config? _instance;

    /*
     * This is the only method to get access to the Config instance
     *
     * It is static, so it is easily, globally accessible.
     */
    public static Config Get()
    {
        if (_instance == null)
        {
            _instance = new Config(DateTime.Now);
        }

        return _instance;
    }

    /*
     * This constructor is private, other classes must use the `Get`
     * operation to get access to an instance.
     */
    private Config(DateTime createdAt)
    {
        CreatedAt = createdAt;
        Format = FormatMarker;
        Transforms = TransformFlags.None;
    }

    #endregion

    public DateTime CreatedAt { get; }
    public string Format { get; set; }
    public string FormatMarker => "{_}";
    public TransformFlags Transforms { get; set; }


    [Flags]
    public enum TransformFlags
    {
        None = 0,
        Uppercase = 1 << 0,
        Exclaim = 1 << 1,
        Aside = 1 << 2
    }
}