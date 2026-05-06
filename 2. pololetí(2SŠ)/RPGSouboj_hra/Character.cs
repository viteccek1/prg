public abstract class Character : Entity
{
    public int Level { get; set; }
    public int MaxHealth { get; set; }
    
    public Character(string name, int health, int level) : base(name, health)
    {
        Level = level;
        MaxHealth = health; 
    }

    public virtual void LevelUp()
    {
        Level++;
        Console.WriteLine($"{Name} postoupilo na level {Level}!");
    }
}