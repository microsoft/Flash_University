using Factory_Method.Analyzer;

namespace Factory_Method;

/*
 * TODO Exercise: implement the SwitchDataset command
 */

/**
 * A CLI for calculating simple statistics on generated number lists
 */
public class Cli
{
    public Cli()
    {
        _analyzer = new DatasetAnalyzer();

        _commands = new()
        {
            { "switch-dataset", SwitchDataset },
            { "run-analysis", RunAnalysis }
        };
    }

    public static string Title = "Dataset Analyzer";

    private DatasetAnalyzer _analyzer;

    #region commands

    private readonly Dictionary<string, Action> _commands;

    /**
     * Switches which type of dataset is being used
     * (ie how the dataset is generated)
     */
    public void SwitchDataset()
    {
        Console.WriteLine("dataset type:");
        var datasetType = Console.ReadLine();

        // TODO Exercise: implement this
    }

    /**
     * Gets a number from user input.
     *
     * This can be used with UserProvidedDataset
     */
    private int GetNumber()
    {
        int? num = null;
        while (num == null)
        {
            Console.Write("> ");
            var input = Console.ReadLine();


            if (int.TryParse(input, out var value))
            {
                num = value;
            }
            else
            {
                Console.WriteLine("not a valid number");
            }
        }

        return num.Value;
    }

    /**
     * Generate the dataset, analyze it, and print out the results
     */
    public void RunAnalysis()
    {
        var summary = _analyzer.RunAnalysis();

        Console.WriteLine($"data (sorted): {String.Join(", ", summary.SortedData)}");
        Console.WriteLine($"min: {summary.Min}");
        Console.WriteLine($"max: {summary.Max}");
        Console.WriteLine($"average: {summary.Average}");
        Console.WriteLine($"median: {summary.Median}");
        Console.WriteLine($"sum: {summary.Sum}");
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
