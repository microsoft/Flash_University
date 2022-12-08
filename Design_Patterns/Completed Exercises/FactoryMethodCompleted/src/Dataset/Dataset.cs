namespace Factory_Method.Dataset;

/**
 * The dataset interface
 */
public interface IDataset
{
    public List<int> Data { get; }
}

/**
 * A dataset with static data
 */
public class StaticDataset : IDataset
{
    public StaticDataset(int size)
    {
        Data = new List<int>(size);

        for (var i = 0; i < size; i++)
        {
            Data.Add(i);
        }
    }

    public List<int> Data { get; }
}

/**
 * A dataset with randomly generated data
 */
public class RandomDataset : IDataset
{
    public RandomDataset(int min, int max, int size)
    {
        var random = new Random();

        Data = new List<int>(size);

        for (var i = 0; i < size; i++)
        {
            Data.Add(random.Next(min, max));
        }
    }

    public List<int> Data { get; }
}

/**
 * A dataset created from user input
 */
public class UserProvidedDataset : IDataset
{
    public UserProvidedDataset(Func<int> getNumber, int size)
    {
        Data = new List<int>(size);

        for (var i = 0; i < size; i++)
        {
            Data.Add(getNumber());
        }
    }

    public List<int> Data { get; }
}