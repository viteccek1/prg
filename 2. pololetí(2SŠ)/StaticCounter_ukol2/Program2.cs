
class Program
{
    static void Main()
    {
        List<Enemy> enemies = new List<Enemy>
        {
            new Enemy("Goblin", 100),
            new Enemy("Orc", 200),
            new Enemy("Troll", 500)
        };

        Console.WriteLine("Normální obtížnost ");
        PrintEnemies(enemies);

        Enemy.SetDifficulty(2.5);

        Console.WriteLine("\nTěžká obtížnost ");
        PrintEnemies(enemies);
    }
    static void PrintEnemies(List<Enemy> enemies)
    {
        foreach (Enemy e in enemies)
        {
            Console.WriteLine($"ID: {e.Id}, Jméno: {e.Name}, Životy: {e.CurrentHealth}");
        }
    }
}