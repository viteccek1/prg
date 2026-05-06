//KROK 4
public class Warrior : Character, IBlockable
{
    public string WeaponName { get; set; }

    public Warrior(string name, int health, int level, string weaponName) : base(name, health, level)
    {
        WeaponName = weaponName;
        
    }
    
    public override void Attack(Entity target)
    {
        var damage = Level * 8;
        Console.WriteLine($"{Name} útočí zbraní {WeaponName} na {target.Name}!");
        target.TakeDamage(damage);
    }
    
    public bool Block()
    {
        if (Random.Shared.Next(100) < 40)
        {
            Console.WriteLine($"{Name} zablokoval útok!");
            return true;
        }
        return false;
    }
    
    public override void LevelUp()
    {
        base.LevelUp();
        Console.WriteLine("Válečníkova síla roste!");
    }
}