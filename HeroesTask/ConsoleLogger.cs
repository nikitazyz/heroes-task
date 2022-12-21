using HeroesTask.Abstract;

namespace HeroesTask;

public class ConsoleLogger : ILogger
{
    private ConsoleColor _consoleColor;

    public ConsoleLogger(ConsoleColor consoleColor)
    {
        _consoleColor = consoleColor;
    }

    public void SendMessage(string message)
    {
        var defaultColor = Console.BackgroundColor;
        Console.BackgroundColor = _consoleColor;
        
        Console.WriteLine(message);

        Console.BackgroundColor = defaultColor;
    }
}