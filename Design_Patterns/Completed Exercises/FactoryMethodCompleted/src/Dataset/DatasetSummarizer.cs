namespace Factory_Method.Dataset;

/**
 * Some calculated statistics of a dataset
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
 * Summarizes a dataset
 * This is the abstract "Creator"
 */
public abstract class DatasetSummarizerBase
{
    public DatasetSummary GetDatasetSummary()
    {
        var dataset = CreateDataset(_random.Next(3, 15));

        var sortedData = new List<int>(dataset.Data);
        sortedData.Sort();

        var sum = sortedData.Aggregate((currentSum, num) => currentSum + num);

        return new DatasetSummary
        {
            SortedData = sortedData,
            Min = sortedData.First(),
            Max = sortedData.Last(),
            Average = (double)sum / sortedData.Count,
            Median = sortedData[sortedData.Count / 2 - 1],
            Sum = sum
        };
    }

    public abstract IDataset CreateDataset(int size);
    
    private readonly Random _random = new();
}

/**
 * The Dataset Summarizer for StaticDataset
 * This is a "ConcreteCreator"
 */
public class StaticDatasetSummarizer : DatasetSummarizerBase
{
    public override IDataset CreateDataset(int size)
    {
        return new StaticDataset(size);
    }
}

/**
 * The Dataset Summarizer for RandomDataset
 * This is a "ConcreteCreator"
 */
public class RandomDatasetSummarizer : DatasetSummarizerBase
{
    public override IDataset CreateDataset(int size)
    {
        return new RandomDataset(0, 10, size);
    }
}

/**
 * The Dataset Summarizer for UserProvidedDataset
 * This is a "ConcreteCreator"
 */
public class UserProvidedDatasetSummarizer : DatasetSummarizerBase
{
    public UserProvidedDatasetSummarizer(Func<int> getNumber)
    {
        _getNumber = getNumber;
    }

    public override IDataset CreateDataset(int size)
    {
        return new UserProvidedDataset(_getNumber, size);
    }

    private readonly Func<int> _getNumber;
}