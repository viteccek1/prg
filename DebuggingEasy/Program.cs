//2.1 Úkol 1 - Oprav funkci
Console.Clear();
void Greet()
{
    Console.WriteLine("Ahoj!");
}
Greet();
Greet();
Greet();

//2.2 Úkol 2 - Doplň podmínky
Console.Write("Zadej číslo: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Kladné číslo");
}
else if (number < 0)
{
    Console.WriteLine("Záporné číslo");
}
else
{
    Console.WriteLine("Cislo je nula");
}

//2.3 Úkol 3 - Oprav cyklus while
int x = 1;
while (x <= 5)
{
    Console.WriteLine(x++);
}

//2.4 Úkol 4 - Funkce s parametrem
void PrintText(string text)
{
    Console.WriteLine(text);
}
PrintText("Programování je zábava");

//2.5 Úkol 5 - Oprava cyklu for
for (int i = 0; i < 5; i++)
{
    Console.Write("*");
}