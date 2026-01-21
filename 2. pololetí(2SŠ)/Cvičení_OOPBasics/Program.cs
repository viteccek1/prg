Console.Clear();

Wall wall = new Wall(2, 2, "Rock");
wall.PrintInfo();
Console.WriteLine();

Wall wall1 = new Wall(8, 4, "Wood");
wall1.PrintInfo();


class Wall
{
    public float height;
    public float width;
    public string material;
    
    public Wall (float height, float width, string material)
    {
        this.height = height;
        this.width = width;
        this.material = material;
    }

    public float GetSurface()
    {
        return height * width;
    }
    
    public void PrintInfo()
    {
        Console.WriteLine($"Plocha je: " + GetSurface() + "^2");
        Console.WriteLine($"Material je: " + material);
    } 
}

