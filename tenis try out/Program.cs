int pocetGamu = 5;
int pocetSetu = 1;


int setyA = 0;
int setyB = 0;
int gamyA = 0;
int gamyB = 0;
int bodyA = 0;
int bodyB = 0;

string[] tenisBody = { "0", "15", "30", "40" };
string advantage = "";

while (true)
{
    Console.Clear();

    string vypisBodyA = bodyA < 4 ? tenisBody[bodyA] : "40";
    string vypisBodyB = bodyB < 4 ? tenisBody[bodyB] : "40";
    if (advantage == "a") vypisBodyA = "A";
    if (advantage == "b") vypisBodyB = "A";

    Console.WriteLine($"Sety: {setyA}-{setyB}");
    Console.WriteLine($"Gamy: {gamyA}-{gamyB}");
    Console.WriteLine($"Body: {vypisBodyA}-{vypisBodyB}");
    
    string vstup = "";
    while (true)
    {
        Console.Write("Jaký hráč má dostat bod? (a/b): ");
        vstup = Console.ReadLine();

        if (vstup == "a" || vstup == "b")
            break; 
        else
            Console.WriteLine("Zadána nesprávná hodnota! Zadej (a) nebo (b)!");
    }
    
    if (advantage == "")
    {
        if (bodyA == 3 && bodyB == 3)
        {
            advantage = vstup;
        }
        else
        {
            if (vstup == "a") bodyA++;
            else bodyB++;
            
            if (bodyA > 3)
            {
                gamyA++;
                bodyA = 0;
                bodyB = 0;
            }
            else if (bodyB > 3)
            {
                gamyB++;
                bodyA = 0;
                bodyB = 0;
            }
        }
    }
    else
    {
        if (advantage == vstup)
        {
            if (advantage == "a") gamyA++;
            else gamyB++;

            bodyA = 0;
            bodyB = 0;
            advantage = "";
        }
        else
        {
            advantage = "";
        }
    }
    
    if (gamyA == pocetGamu)
    {
        setyA++;
        gamyA = 0;
        gamyB = 0;
    }
    else if (gamyB == pocetGamu)
    {
        setyB++;
        gamyA = 0;
        gamyB = 0;
    }
    
    if (setyA == pocetSetu)
    {
        Console.WriteLine("Vyhrál hráč A!");
        break;
    }
    else if (setyB == pocetSetu)
    {
        Console.WriteLine("Vyhrál hráč B!");
        break;
    }
}