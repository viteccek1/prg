public abstract class Entity
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Entity(string name, int health)
    {
        Name = name;
        Health = health;
    }
    
    public bool IsAlive()
    {
        return Health > 0;
    }
    
    public abstract void Attack(Entity target);

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }
        Console.WriteLine($"{Name} obdrželo: {damage} poškození. Zbývá: {Health} HP");
    }
    
}