using System.Diagnostics.CodeAnalysis;

namespace State;

/**
 * A simple CLI for creating and publishing notes
 *
 * All the command methods are in the "commands" region
 */
public class Cli
{
    private readonly List<Note> _notes = new();

    #region command runner

    public void Run()
    {
        Console.WriteLine("Note Publishing System");

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
                ListNotes();
            }
            else if (command == "show")
            {
                ShowNote();
            }
            else if (command == "create")
            {
                CreateNote();
            }
            else if (command == "update")
            {
                UpdateNote();
            }
            else if (command == "delete")
            {
                DeleteNote();
            }
            else if (command == "review")
            {
                ReviewNote();
            }
            else if (command == "publish")
            {
                PublishNote();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: " +
                                  "'list', 'show', 'create', 'update', 'delete', 'review', 'publish', 'quit', 'exit'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    #endregion

    #region commands

    public void ListNotes()
    {
        if (_notes.Count == 0)
        {
            Console.WriteLine("no notes have been created");
            return;
        }

        for (var i = 0; i < _notes.Count; i++)
        {
            var note = _notes[i];
            Console.WriteLine($"[{i}] {note.Name} ({note.Status})");
        }
    }

    public void ShowNote()
    {
        var note = GetNote();

        Console.WriteLine("\n" + note.GetContent());
    }

    public void CreateNote()
    {
        Console.Write("name: ");
        var name = Console.ReadLine() ?? "";
        var note = new Note(name);

        _notes.Add(note);

        Console.WriteLine("content:");
        var content = ReadMultipleLines();

        note.UpdateContent(content);

        Console.WriteLine($"created note [{note.Name}]");
    }

    public void DeleteNote()
    {
        var note = GetNote();

        _notes.Remove(note);

        Console.WriteLine($"deleted note [{note.Name}]");
    }

    public void UpdateNote()
    {
        var note = GetNote();

        Console.WriteLine("content:");
        var content = ReadMultipleLines();

        note.UpdateContent(content);

        Console.WriteLine($"updated note [{note.Name}]");
    }

    public void ReviewNote()
    {
        var note = GetNote();

        Console.WriteLine(note.GetContent() + "\n");

        Console.Write("approve (y/N)? ");
        var approve = ReadYesNo();

        note.Review(approve);

        if (approve)
            Console.WriteLine($"approved note [{note.Name}]");
        else
            Console.WriteLine($"did not approve note [{note.Name}]");
    }

    public void PublishNote()
    {
        var note = GetNote();

        note.Publish();

        Console.WriteLine($"published note [{note.Name}]");
    }

    #endregion

    private Note GetNote()
    {
        Console.Write("note id: ");
        var rawId = Console.ReadLine();
        var parseSuccessful = int.TryParse(rawId, out var id);

        if (!parseSuccessful || id < 0 || id > _notes.Count)
        {
            throw new Exception($"unable to get note {rawId}");
        }

        return _notes[id];
    }

    private string ReadMultipleLines()
    {
        var text = "";
        var line = Console.ReadLine() ?? "";

        while (line != "")
        {
            if (text != "") text += "\n";
            text += line;

            line = Console.ReadLine() ?? "";
        }

        return text;
    }

    private bool ReadYesNo()
    {
        var rawValue = Console.ReadLine() ?? "";
        return rawValue.Equals("y", StringComparison.OrdinalIgnoreCase);
    }
}