class Goblin : Enemy
{
    public Goblin(int health) : base("Goblin", 50)
    {
        
    }

    public override void Attack(Entity target)
    {
        Console.WriteLine("Goblin škrábe a způsobuje 8 poškození!");
        target.TakeDamage(8);
    }
}