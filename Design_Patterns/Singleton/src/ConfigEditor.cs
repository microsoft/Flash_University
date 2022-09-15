namespace Singleton;

/**
 * Utility class for editing the Config
 *
 * This class gets a Config instance on creation, saves it
 * to a field, and reuses it in all method calls.
 */
public class ConfigEditor
{
    private readonly Config _config;
    public ConfigEditor()
    {
        _config = Config.Get();
    }

    #region public methods

    public string ShowConfig()
    {
        return $"config (created at: {_config.CreatedAt:G})\n" +
               $"    format = \"{_config.Format}\"\n" +
               $"    transforms = {_config.Transforms}";
    }

    public void SetFormat(string format)
    {
        if (!format.Contains(_config.FormatMarker))
        {
            throw new Exception($"format string must contain \"{_config.FormatMarker}\"");
        }

        _config.Format = format;
    }

    public void AddTransform(string transformName)
    {
        var transform = GetMatchingTransform(transformName);
        _config.Transforms |= transform;
    }

    public void RemoveTransform(string transformName)
    {
        var transform = GetMatchingTransform(transformName);
        _config.Transforms &= ~transform;
    }

    #endregion

    #region Transform Flag helpers

    private Config.TransformFlags GetMatchingTransform(string transformName)
    {
        var validTransform = Enum.TryParse(transformName, out Config.TransformFlags transform);

        if (!validTransform)
        {
            throw new Exception($"\"{transformName}\" is not a valid transform; valid transforms are {string.Join(", ", TransformNames)}");
        }

        return transform;
    }

    private static readonly string[] TransformNames = Enum.GetNames(typeof(Config.TransformFlags));

    #endregion
}