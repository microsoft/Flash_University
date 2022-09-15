namespace Singleton;

/**
 * Utility class for transforming text based on the config
 *
 * This class gets a Config instance on on-the-fly whenever
 * a method needs it (hence there is no Config field).
 */
public class TextTransformer
{
    public int NumTimesTransformed { get; private set; }

    public string Transform(string text)
    {
        var config = Config.Get();

        var transformed = GetTransformed(config, text);
        var formatted = GetFormatted(config, transformed);

        NumTimesTransformed += 1;
        return formatted;
    }

    private string GetFormatted(Config config, string text)
    {
        return config.Format.Replace(config.FormatMarker, text);
    }

    private string GetTransformed(Config config, string text)
    {
        var transformed = text;

        if (config.Transforms.HasFlag(Config.TransformFlags.Uppercase))
        {
            transformed = transformed.ToUpper();
        }

        if (config.Transforms.HasFlag(Config.TransformFlags.Exclaim))
        {
            transformed = $"{transformed}!";
        }

        if (config.Transforms.HasFlag(Config.TransformFlags.Aside))
        {
            transformed = $"({transformed})";
        }

        return transformed;
    }
}