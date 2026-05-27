namespace Pokedex;

public class CommandRegistry
{
    
    public static Task Clear(PokedexState state)
    {
        Console.Clear();
        return Task.CompletedTask; 
    }

    
    public static Task Exit(PokedexState state)
    {
        Console.WriteLine("Exit CommandRegistry");
        Environment.Exit(0);
        return Task.CompletedTask;
    }
    
    
    public static Task Help(PokedexState state)
    {
        Console.WriteLine("Pokedex CLI");
        Console.WriteLine();
        foreach (var com in GetCommands()) 
        {
            
            Console.WriteLine($"{com.Name,-10}: {com.Description}");
        }
        return Task.CompletedTask;
    }

    public static List<Command> GetCommands()
    {
        return
        [
            new Command("exit", "Exits the app", Exit),
            new Command("help", "Displays help", Help),
            new Command("clear", "Clears the screen", Clear),
            new Command("map", "Displays the next 20 locations", MapCommands.Map),
            new Command("mapb", "Displays the previous 20 locations", MapCommands.MapBack)
        ];
    }
}