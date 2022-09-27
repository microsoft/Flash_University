namespace Strategy;

/**
 * A simple CLI for a guessing number game
 *
 * This class determines what strategy to use (based on user input),
 * and constructs a NumberGuesser (the "Context") with the chosen
 * strategy instance
 *
 * The game itself is simple - you think of a number, the computer
 * will try to guess it. On each guess, you can reply 'lower', 'higher'
 * or 'correct'; the computer will keep guessing until it gets it correct
 * or it runs out of guesses (should only happen if it gets contradictory
 * information, ie lower than 5, higher than 6)
 */
public class Cli
{
    #region command runner

    public void Run()
    {
        Console.WriteLine("Number Guessing Game");

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
            if (command == "start")
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("unknown command: {0}", command);
                Console.WriteLine("valid commands are: " +
                                  "'start', 'quit', 'exit'");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
    }

    #endregion

    #region game

    /**
     * command to start a game
     */
    private void StartGame()
    {
        Console.Write("use which guessing strategy? (basic, random, binary-search) ");
        
        var strategyType = Console.ReadLine() ?? "";

        // We pick the strategy based on user input here, and pass it to NumberGuesser to use
        // (Dependency Injection here!)
        NumberGuesser guesser = new NumberGuesser(GetStrategy(strategyType));

        Console.WriteLine($"think of a number {NumberGuesser.Min}-{NumberGuesser.Max}, and I will try to guess it");
        Console.WriteLine("(respond 'lower', 'higher', 'correct', or 'stop')");

        var responseText = "";
        while (responseText != "correct" && responseText != "stop")
        {
            var response = GetResponse(responseText);
            int? guess = guesser.Guess(response);

            if (guess == null)
            {
                Console.WriteLine("ran out of guesses...");
                break;
            }

            Console.Write($"is it {guess}? ");
            responseText = Console.ReadLine() ?? "";
        }

        if (responseText == "correct")
        {
            Console.WriteLine("yay, I guessed it!");
        } 
    }

    /**
     * Simple mapping from string -> IGuesserStrategy
     *
     * This is where we instantiate the chosen "Concrete Strategy",
     * which will be passed to the NumberGuess (aka "Context")
     */
    private IGuesserStrategy GetStrategy(string strategyType)
    {
        return strategyType switch
        {
            "basic" => new BasicGuesser(),
            "random" => new RandomGuesser(),
            "binary-search" => new BinarySearchGuesser(),
            _ => throw new Exception($"{strategyType} is not a valid strategy type")
        };
    }

    /**
     * Simple mapping from string -> GuessResponse
     */
    private GuessResponse? GetResponse(string text)
    {
        return text switch
        {
            "lower" => GuessResponse.Lower,
            "higher" => GuessResponse.Higher,
            _ => null
        };
    }


    #endregion
}