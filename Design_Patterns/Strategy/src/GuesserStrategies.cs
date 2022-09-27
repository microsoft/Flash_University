namespace Strategy;

public class BasicGuesser : IGuesserStrategy
{
    public int CurrentGuess { get; private set; } = NumberGuesser.Min;

    public bool HasMoreGuesses()
    {
            return CurrentGuess < NumberGuesser.Max;
    }

    public int NextGuess(GuessResponse previousResponse)
    {
        CurrentGuess += 1;
        return CurrentGuess;
    }
}

public class RandomGuesser : IGuesserStrategy
{
    private readonly Random _random = new Random();
    public int CurrentGuess { get; private set; }

    public RandomGuesser()
    {
        CurrentGuess = _random.Next(NumberGuesser.Min, NumberGuesser.Max);
    }

    public bool HasMoreGuesses()
    {
        return true;
    }

    public int NextGuess(GuessResponse previousResponse)
    {
        CurrentGuess = _random.Next(NumberGuesser.Min, NumberGuesser.Max);
        return CurrentGuess;
    }
}

public class BinarySearchGuesser : IGuesserStrategy
{
    public int LowerBound { get; private set; } = NumberGuesser.Min;
    public int UpperBound { get; private set; } = NumberGuesser.Max;

    public int CurrentGuess => GetMidpoint();

    public bool HasMoreGuesses()
    {
        return LowerBound < UpperBound;
    }

    public int NextGuess(GuessResponse previousResponse)
    {
        if (previousResponse == GuessResponse.Lower)
        {
            UpperBound = CurrentGuess - 1;
        }
        else
        {
            LowerBound = CurrentGuess + 1;
        }

        return CurrentGuess;
    }

    private int GetMidpoint()
    {
        return (LowerBound + UpperBound) / 2;
    }
}