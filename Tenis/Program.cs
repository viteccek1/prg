Console.Clear();
int pocetGamu = 6;
int maxSetu = 2;

int setyA = 0;
int setyB = 0;

int gamyA = 0;
int gamyB = 0;

int[] tenisBody = { 0, 15, 30, 40 };
int indexA = 0;
int indexB = 0;

bool vyhodaA = false; 
bool vyhodaB = false; 

void Skore()
{
    Console.Clear();

    string bodA = tenisBody[indexA].ToString();
    string bodB = tenisBody[indexB].ToString();

    
    if (vyhodaA) bodA = "A";
    if (vyhodaB) bodB = "A";

    Console.WriteLine($"Body: {bodA} - {bodB}");
    Console.WriteLine($"Gamy: {gamyA} - {gamyB}");
    Console.WriteLine($"Sety: {setyA} - {setyB}");
}

Skore();

while (true)
{
    Console.Write("Kdo získal bod (a/b): ");
    string input = Console.ReadLine();

 
    if (gamyA == pocetGamu)
    {
        Console.WriteLine("Hráč A vyhrál hru!");
        break;
    }
    else if (gamyB == pocetGamu)
    {
        Console.WriteLine("Hráč B vyhrál hru!");
        break;
    }

   
    bool deuce = (indexA == 3 && indexB == 3 && !vyhodaA && !vyhodaB);

    if (input == "a")
    {
        if (deuce)
        {
            vyhodaA = true;
        }
        else if (vyhodaA)
        {
            gamyA++;
            indexA = 0;
            indexB = 0;
            vyhodaA = false;
            vyhodaB = false;
        }
        else if (vyhodaB)
        {
            vyhodaB = false;
        }
        else if (indexA < 3)
        {
            indexA++;
        }
        else
        {
            gamyA++;
            indexA = 0;
            indexB = 0;
        }

        if (gamyA >= pocetGamu)
        {
            setyA++;
            gamyA = 0;
            gamyB = 0;
            Console.WriteLine("Hráč A vyhrál set!");
            Console.ReadKey();
        }
        if (setyA == 2)
        {
            Skore();
            Console.WriteLine("Hráč A vyhrál zápas!");
            break;
        }
    }
    else if (input == "b")
    {
        if (deuce)
        {
            vyhodaB = true;
        }
        else if (vyhodaB)
        {
            gamyB++;
            indexA = 0;
            indexB = 0;
            vyhodaA = false;
            vyhodaB = false;
        }
        else if (vyhodaA)
        {
            vyhodaA = false;
        }
        else if (indexB < 3)
        {
            indexB++;
        }
        else
        {
            gamyB++;
            indexA = 0;
            indexB = 0;
        }

        if (gamyB >= pocetGamu)
        {
            setyB++;
            gamyA = 0;
            gamyB = 0;
            Console.WriteLine("Hráč B vyhrál set!");
            Console.ReadKey();
        }
        if (setyB == 2)
        {
            Skore();
            Console.WriteLine("Hráč B vyhrál zápas!");
            break;
        }
    }

    Skore();
}
