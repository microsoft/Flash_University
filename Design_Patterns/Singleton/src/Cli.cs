namespace Singleton;

/**
 * A simple CLI for transforming text based on a config
 *
 * Does not use the Config directly (but has two fields that
 * use the Config)
 */
public class Cli
{
    /**
     * Both _configEditor and _transformer use the Config, but
     * because of the "global point of access" (aka static `Get` method),
     * both fields can access Config on their own - the Cli doesn't
     * have to care about Config.
     */
    private readonly ConfigEditor _configEditor = new ConfigEditor();
    private readonly TextTransformer _transformer = new TextTransformer();

    #region command runner

    public void Run()
    {
        Console.WriteLine("Text Transforming System (using config)");

        var command = GetNextCommand();

        while (command != null && command != "quit" && command != "exit")
        {
            RunCommand(command);
            command = GetNextCommand();
        }
    }

    private string? GetNextCommand()
    {
        Console.Write("\n> ");
        return Console.ReadLine();
    }

    private void RunCommand(string command)
    {
        try
        {
            if (command == "edit-config")
            {
                EditConfig();
            }
            else if (command == "show-config")
            {
                ShowConfig();
            }
            else if (command == "transform")
            {
                Transform();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: " +
                                  "'edit-config', 'show-config', 'transform', 'quit', 'exit'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    #endregion

    #region commands

    public void EditConfig()
    {
        Console.Write("property: ");
        var property = Console.ReadLine() ?? "";

        if (property == "format")
        {
            EditConfigFormat();
        } else if (property == "transforms")
        {
            EditConfigTransforms();
        }
        else
        {
            throw new Exception($"unknown config property {property}; valid properties are 'format', 'transforms'");
        }
    }

    private void EditConfigFormat()
    {
        Console.Write("new format: ");
        var format = Console.ReadLine() ?? "";

        _configEditor.SetFormat(format);

        Console.WriteLine("updated config format");
    }

    private void EditConfigTransforms()
    {
        Console.Write("do you want to 'add' or 'remove' a transform? ");
        var addRemove = Console.ReadLine() ?? "";

        Console.Write("transform: ");
        var transform = Console.ReadLine() ?? "";

        if (addRemove == "add")
        {
            _configEditor.AddTransform(transform);
        } else if (addRemove == "remove")
        {
            _configEditor.RemoveTransform(transform);
        }
        else
        {
            throw new Exception($"invalid option {addRemove}; valid options is 'add' or 'remove'");
        }

        Console.WriteLine("updated config transforms");
    }

    public void ShowConfig()
    {
        Console.WriteLine(_configEditor.ShowConfig());
    }

    public void Transform()
    {
        Console.Write("text: ");
        var text = Console.ReadLine() ?? "";

        var transformed = _transformer.Transform(text);

        Console.WriteLine($"transformed ({_transformer.NumTimesTransformed}): {transformed}");
    }
    
    #endregion
}