public class Mage : Character, IHealable
{
    
    public int ManaPoints { get; set; } 
    
    public Mage(string name, int health, int level, int manaPoints) : base(name, health, level)
    {
        ManaPoints = manaPoints;
    }
    
    public override void Attack(Entity target)
    {
        if (ManaPoints < 10)
        {
            Console.WriteLine($"{Name} nemá dostatek many!");
            return;
        }
        
        var damage = ManaPoints / 2;
        ManaPoints -= 10;
        
        Console.WriteLine($"{Name} sesílá ohnivou kouli a způsobuje {damage} poškození! Zbývá {ManaPoints} many.");
        target.TakeDamage(damage);
    }
    

    public void Heal(int amount)
    {
        if (ManaPoints < 20)
        {
            Console.WriteLine($"{Name} nemá dost many na léčení!");
            return;
        }
        
        ManaPoints -= 10;
        Health += amount;
        
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
        
        Console.WriteLine($"{Name} se vyléčilo o {amount} HP. Nyní má {Health} HP.");
    }
}