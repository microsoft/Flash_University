using Proxy.Library;

namespace Proxy;

/**
 * A simple CLI for viewing images
 */
public class Cli
{
    public Cli()
    {
        _commands = new()
        {
            { "list", List },
            { "details", Details }
        };

        _library = new ImageLibrary();
    }

    public static string Title = "Image Viewer";

    private readonly ImageLibrary _library;

    #region commands

    private readonly Dictionary<string, Action> _commands;

    /**
     * List all of the images and their properties
     */
    public void List()
    {
        var names = _library.GetImageNames();

        foreach (var name in names)
        {
            var image = _library.GetImage(name);
            Console.WriteLine($"{image.Name} ({image.Width}x{image.Height})");
        }
    }

    /**
     * Show the details of an image
     */
    public void Details()
    {
        Console.Write("name: ");
        var name = Console.ReadLine() ?? "";

        var image = _library.GetImage(name);
        Console.WriteLine($"\n{image.Name}");
        Console.WriteLine($"dimensions: {image.Width}x{image.Height}");
        Console.WriteLine($"caption: {image.Caption}");
    }

    #endregion

    #region command runner

    public void Run()
    {
        Console.WriteLine(Title);

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
            if (_commands.TryGetValue(command, out var commandAction))
            {
                commandAction();
            }
            else
            {
                String.Join("', '", _commands.Keys);

                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine($"valid commands are: '{String.Join("', '", _commands.Keys)}'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    #endregion
}