namespace Strategy;

/**
 * A basic guessing strategy
 *
 * This is a "Concrete Strategy"
 *
 * It simply starts at the minimum guess value and goes one by one
 * up to the max guess value. It runs out of guesses if it
 * makes it to the max guess value.
 */
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

/**
 * A suboptimal guessing strategy that guesses randomly
 *
 * This is a "Concrete Strategy"
 *
 * This strategy guesses a random number each time (and does not avoid
 * re-guessing an already guessed number). It never runs out of guesses.
 */
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

/**
 * A guessing strategy that performs a binary search
 *
 * This is a "Concrete Strategy"
 *
 * This strategy starts at the middle value, and based on the higher/lower
 * responses, continually narrows the possible range via binary search.
 * It runs out of guesses if the guess range becomes empty.
 */
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