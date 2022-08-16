namespace Template_Method;

/**
 * A simple CLI for viewing, creating, updated,
 * and deleting in-memory files
 */
public class Cli
{
    private readonly FileSystem _fs = new MemoryFileSystem();

    #region command runner

    public void Run()
    {
        Console.WriteLine("Virtual File Browser");

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
            if (command == "list")
            {
                PrintFiles();
            }
            else if (command == "show")
            {
                ShowFile();
            }
            else if (command == "create")
            {
                CreateFile();
            }
            else if (command == "update")
            {
                UpdateFile();
            }
            else if (command == "delete")
            {
                DeleteFile();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: 'list', 'show', 'create', 'update', 'delete', 'quit', 'exit'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }
    
    #endregion

    #region commands

    private void PrintFiles()
    {
        foreach (var file in _fs.ListFiles()) Console.WriteLine(file);
    }

    private void ShowFile()
    {
        Console.Write("filename: ");
        var filename = Console.ReadLine() ?? "";
        var file = _fs.GetFile(filename);

        Console.WriteLine(file.GetContent());
    }

    private void CreateFile()
    {
        Console.Write("filename: ");
        var filename = Console.ReadLine() ?? "";

        var file = _fs.CreateFile(filename);

        Console.WriteLine("content:");
        var content = Console.ReadLine();

        file.Overwrite(content ?? "");

        Console.WriteLine("Created new file {0}", filename);
    }

    private void UpdateFile()
    {
        Console.Write("filename: ");
        var filename = Console.ReadLine() ?? "";

        var file = _fs.GetFile(filename);

        Console.Write("overwrite existing content (y/n)? ");
        var shouldOverwrite = Console.ReadLine();

        Console.WriteLine("content:");
        var content = Console.ReadLine() ?? "";

        if (shouldOverwrite == "y")
            file.Overwrite(content);
        else
            file.Append(content);

        Console.WriteLine("Updated file {0}", filename);
    }

    private void DeleteFile()
    {
        Console.Write("filename: ");
        var filename = Console.ReadLine() ?? "";
        _fs.DeleteFile(filename);

        Console.WriteLine("Deleted file {0}", filename);
    }
    
    #endregion
}