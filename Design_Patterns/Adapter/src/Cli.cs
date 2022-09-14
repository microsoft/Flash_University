namespace Adapter;

/**
 * Simple interface used for transforming text
 *
 * This is the "Target" interface
 */
public interface ITransformer
{
    public void SetText(string text);
    public string GetBaseText();

    public string Uppercase();
    public string Exclaim();
    public string Shout();
    public string Whisper();
}

/**
 * A simple CLI for transforming text
 *
 * This is the "Client"
 *
 * The CLI uses a ITransformer instance to do the text
 * transformation - it doesn't care what actually implements
 * the functionality, it just has to match the ITransformer interface.
 *
 * (All the command methods are in the "commands" region)
 */
public class Cli
{
    private readonly ITransformer _transformer;

    /*
     * The ITransformer object is passed in through this constructor,
     * hence the CLI has no knowledge (nor does it care) what
     * actual class it is
     */
    public Cli(ITransformer transformer)
    {
        _transformer = transformer;
    }

    #region command runner

    public void Run()
    {
        Console.WriteLine("Text Transforming System");

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
            if (command == "set-text")
            {
                SetText();
            }
            else if (command == "show")
            {
                Show();
            }
            else if (command == "uppercase")
            {
                Uppercase();
            }
            else if (command == "exclaim")
            {
                Exclaim();
            }
            else if (command == "shout")
            {
                Shout();
            }
            else if (command == "whisper")
            {
                Whisper();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: " +
                                  "'set-text', 'show', 'uppercase', 'exclaim', 'shout', 'whisper', 'quit', 'exit'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    #endregion

    #region commands

    public void SetText()
    {
        Console.Write("text: ");
        var text = Console.ReadLine() ?? "";

        _transformer.SetText(text);

        Console.WriteLine("updated base text");
    }

    public void Show()
    {
        Console.WriteLine(_transformer.GetBaseText());
    }

    public void Uppercase()
    {
        Console.WriteLine(_transformer.Uppercase());
    }

    public void Exclaim()
    {
        Console.WriteLine(_transformer.Exclaim());
    }

    public void Shout()
    {
        Console.WriteLine(_transformer.Shout());
    }

    public void Whisper()
    {
        Console.WriteLine(_transformer.Whisper());
    }

    #endregion
}