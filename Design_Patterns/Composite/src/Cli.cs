using Composite.FileSystem;

namespace Composite;

/*
 * TODO Exercise: finish implementing all the commands
 */

/**
 * A simple CLI for managing files & folders
 */
public class Cli
{
    public Cli()
    {
        // TODO Exercise: what should fileSystem be..?
        // _fileSystem = ???
        _current = _fileSystem;
    }

    private readonly Item _fileSystem;
    private Item _current;

    #region command runner

    public void Run()
    {
        Console.WriteLine("Mini File System");

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
                List();
            }
            else if (command == "details")
            {
                Details();
            }
            else if (command == "cd")
            {
                ChangeDirectory();
            }
            else if (command == "new")
            {
                New();
            }
            else if (command == "delete")
            {
                Delete();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: " +
                                  "'list', 'details', 'cd', 'new', 'delete', 'quit', 'exit'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    #endregion

    #region commands

    /**
     * List all of the files & folders (recursively)
     */
    public void List()
    {
        // TODO Exercise: implement this command
    }

    /**
     * Show details about the current file/folder
     */
    public void Details()
    {
        // TODO Exercise: should this include any other info?
        Console.WriteLine(_current.AbsoluteName);
        Console.WriteLine($"size on disk: {_current.SizeOnDisk} characters");
        Console.WriteLine();
    }

    /**
     * Change the current directory (only supports full names/absolute paths)
     */
    public void ChangeDirectory()
    {
        // TODO Exercise: implement this command
    }

    /**
     * Add new file or folder
     */
    public void New()
    {
        // TODO Exercise: implement this command
    }

    /**
     * Delete a file or folder
     */
    public void Delete()
    {
        // TODO Exercise: implement this command
    }

    #endregion

    #region helpers

    private string[] ParseFull(string fullName)
    {
        return fullName.Split("/");
    }

    #endregion
}