class Dragon : Enemy
{
    public Dragon (int health) : base("Dragon", 120)
    {
        
    }

    public override void Attack(Entity target)
    {
        Console.WriteLine("Drak chrlí oheň a způsobuje 25 poškození!");
        target.TakeDamage(25);
    }
}