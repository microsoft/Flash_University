﻿using Factory_Method.Dataset;
using Utils;

namespace Factory_Method;

/*
 * TODO Exercise: implement the SwitchDataset command
 */

/**
 * A CLI for calculating simple statistics on generated number lists
 */
public class Cli : CliBase
{
    public Cli()
    {
        _summarizer = new DatasetSummarizer();

        Commands.MergeIn(new Dictionary<string, Action>()
        {
            { "switch-dataset", SwitchDataset },
            { "get-summary", GetSummary }
        });
    }

    public override string Title => "Dataset Summarizer";

    private DatasetSummarizer _summarizer;

    #region commands

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

            try
            {
                num = CliUtils.ReadInt();
            }
            catch
            {
                Console.WriteLine("not a valid number");
            }
        }

        return num.Value;
    }

    /**
     * Generate the dataset, generate the summary it, and print out the results
     */
    public void GetSummary()
    {
        var summary = _summarizer.GetDatasetSummary();

        Console.WriteLine($"data (sorted): {String.Join(", ", summary.SortedData)}");
        Console.WriteLine($"min: {summary.Min}");
        Console.WriteLine($"max: {summary.Max}");
        Console.WriteLine($"average: {summary.Average}");
        Console.WriteLine($"median: {summary.Median}");
        Console.WriteLine($"sum: {summary.Sum}");
    }

    #endregion
}
