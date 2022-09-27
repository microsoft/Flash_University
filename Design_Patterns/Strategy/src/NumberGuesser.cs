namespace Strategy;

/**
 * Simple enum for encoding the 'lower'/'higher' responses
 */
public enum GuessResponse
{
    Lower, Higher
}

/**
 * The interface all guesser strategies must follow
 *
 * This is the "Strategy"
 *
 * It exposes 3 things necessary for guessing:
 * - the current guess
 * - if it has more guesses past the current guess
 * - a way to move to the next guess
 */
public interface IGuesserStrategy
{
    public int CurrentGuess { get; }
    public bool HasMoreGuesses();
    public int NextGuess(GuessResponse previousResponse);
}

/**
 * The main class to used to guess the number
 *
 * This is the "Context"
 *
 * It is passed an IGuesserStrategy through the constructor,
 * and uses the strategy to get the actual guess values
 */
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