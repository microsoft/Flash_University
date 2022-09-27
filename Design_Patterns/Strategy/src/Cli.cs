namespace Strategy;

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

    private void StartGame()
    {
        Console.Write("use which guessing strategy? (basic, random, binary-search) ");
        
        var strategyType = Console.ReadLine() ?? "";
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

    private IGuesserStrategy GetStrategy(string strategyType)
    {
        if (strategyType == "basic")
        {
            return new BasicGuesser();
        }
        else if (strategyType == "random")
        {
            return new RandomGuesser();
        }
        else if (strategyType == "binary-search")
        {
            return new BinarySearchGuesser();
        }
        else
        {
            throw new Exception($"{strategyType} is not a valid strategy type");
        }
    }

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