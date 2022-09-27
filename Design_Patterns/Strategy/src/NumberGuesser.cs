namespace Strategy;

public enum GuessResponse
{
    Lower, Higher
}

public interface IGuesserStrategy
{
    public int CurrentGuess { get; }
    public bool HasMoreGuesses();
    public int NextGuess(GuessResponse previousResponse);
}

public class NumberGuesser
{
    public static int Min = 0;
    public static int Max = 10;

    private readonly IGuesserStrategy _strategy;

    public NumberGuesser(IGuesserStrategy strategy)
    {
        _strategy = strategy;
    }

    public int? Guess(GuessResponse? response)
    {
        if (!response.HasValue)
        {
            return _strategy.CurrentGuess;
        }

        if (!_strategy.HasMoreGuesses())
        {
            return null;
        }

        return _strategy.NextGuess(response.Value);
    }
}