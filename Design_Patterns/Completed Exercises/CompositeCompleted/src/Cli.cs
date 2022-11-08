using Composite.FileSystem;
using File = Composite.FileSystem.File;

namespace Composite;

/**
 * A simple CLI for managing files & folders
 */
public class Cli
{
    public Cli()
    {
        _fileSystem = new Folder("~", null);
        _current = _fileSystem;

        PopulateFileSystem(_fileSystem);
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
            else if (command == "new-folder")
            {
                NewFolder();
            }
            else if (command == "new-file")
            {
                NewFile();
            }
            else if (command == "delete")
            {
                Delete();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: " +
                                  "'list', 'details', 'cd', 'new-file', 'new-folder', 'delete', 'quit', 'exit'");
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
        Console.WriteLine(_current.DisplayName);
        ListChildren(_current, "  ");
    }

    private void ListChildren(Item item, string indentation = "")
    {
        foreach (var child in item.GetChildren())
        {
            Console.WriteLine(indentation + child.Value.DisplayName);
            ListChildren(child.Value, indentation + "  ");
        }
    }

    /**
     * Show details about the current file/folder
     */
    public void Details()
    {
        Console.WriteLine(_current.AbsoluteName);
        Console.WriteLine($"size on disk: {_current.SizeOnDisk} characters");
        Console.WriteLine();
    }

    /**
     * Change the current directory (only supports full names/absolute paths)
     */
    public void ChangeDirectory()
    {
        Console.Write("path: ~/");
        var path = ParsePath(Console.ReadLine() ?? "");

        var newFolder = _fileSystem;

        foreach (var folderName in path)
        {
            var nextFolder = newFolder.GetChild(folderName);

            if (nextFolder == null)
            {
                throw new Exception($"folder {folderName} does not exist in {newFolder.AbsoluteName}");
            }

            newFolder = nextFolder;
        }

        _current = newFolder;
    }

    /**
     * Add new file or folder
     */
    public void NewFolder()
    {
        Console.Write("name: ");
        var name = Console.ReadLine() ?? "";

        _current.Add(new Folder(name, _current));

        Console.WriteLine($"added folder {name} to {_current.AbsoluteName}");
    }

    /**
     * Add new file or folder
     */
    public void NewFile()
    {
        Console.Write("name: ");
        var name = Console.ReadLine() ?? "";

        Console.WriteLine("content: ");
        var content = Console.ReadLine() ?? "";

        _current.Add(new FileSystem.File(name, _current, content));

        Console.WriteLine($"added file {name} to {_current.AbsoluteName}");
    }

    /**
     * Delete a file or folder
     */
    public void Delete()
    {
        Console.Write("name: ");
        var name = Console.ReadLine() ?? "";
        
        _current.Remove(name);

        Console.WriteLine($"deleted {name} from {_current.AbsoluteName}");
    }

    #endregion

    #region helpers

    private string[] ParsePath(string fullName)
    {
        if (fullName == "")
        {
            return Array.Empty<string>();
        }

        return fullName.Split("/");
    }

    private static void PopulateFileSystem(Item fileSystem)
    {
        fileSystem.Add(new File("foo.txt", fileSystem, "foo"));

        var stuff = new Folder("stuff", fileSystem);
        fileSystem.Add(stuff);
        stuff.Add(new File("things.txt", stuff, "blah blah blah"));

        var otherStuff = new Folder("other-stuff", stuff);
        stuff.Add(otherStuff);
        otherStuff.Add(new File("more-things.txt", otherStuff, "more things!"));
    }

    #endregion
}