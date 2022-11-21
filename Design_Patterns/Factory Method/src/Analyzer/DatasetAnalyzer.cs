using System.Drawing;

namespace Factory_Method.Analyzer;

/*
 * TODO Exercise: Apply the Factory Method pattern to DatasetAnalyzer
 *
 * The goal is to flexibly allow using different IDataset classes,
 * and to allow someone else (ie the Cli) to be responsible for
 * picking the IDataset class.
 */

/**
 * The calculated statistics of a dataset
 */
public struct DatasetSummary
{
    public List<int> SortedData { get; init; }

    public int Min { get; init; }
    public int Max { get; init; }
    public double Average { get; init; }
    public int Median { get; init; }
    public int Sum { get; init; }
}

/**
 * The Dataset Analyzer
 */
public class DatasetAnalyzer
{
    // TODO Exercise: add a "Factory Method"

    public DatasetSummary RunAnalysis()
    {
        // TODO Exercise: decouple this from StaticDataset
        // instead it should only use IDataset
        StaticDataset dataset = new StaticDataset(_random.Next(3, 15));

        var sortedData = new List<int>(dataset.Data);
        sortedData.Sort();

        var sum = sortedData.Aggregate((currentSum, num) => currentSum + num);

        return new DatasetSummary()
        {
            SortedData = sortedData,
            Min = sortedData.First(),
            Max = sortedData.Last(),
            Average = ((double)sum) / sortedData.Count,
            Median = sortedData[sortedData.Count / 2 - 1],
            Sum = sum,
        };
    }

    private readonly Random _random = new Random();
}
