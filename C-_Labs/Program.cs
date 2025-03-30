// See https://aka.ms/new-console-template for more information



/* INSTRUKCJE STERUJĄCE I PĘTLE */

// Zadanie 4* dodatkowe
Console.WriteLine("Zadanie 4* dodatkowe");


int n = 5;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("*");
    if (i == 4) { break; }
    for (int j = 0; j <= i; j++)
    {
        Console.Write("*");
        if (i == 4) { break; }
    }
}

// Zadanie 5* dodatkowe
Console.WriteLine("---------------------------------------------------------------");
Console.WriteLine("Zadanie 5* dodatkowe");
int exam = 100;
Console.WriteLine("Podaj wynik egzaminu 0 - 100 pkt");
int point = Convert.ToInt32(Console.ReadLine());
exam = point;
if (exam >= 0 && exam <= 39)
{
    Console.WriteLine($"0 - 39 pkt- Ocena Niedostateczna");
} else if(exam >= 40 && exam <= 54){
    Console.WriteLine($"40 - 54 pkt- Ocena Dopuszczająca");
} else if(exam >= 55 &&  exam <= 69)
{
    Console.WriteLine($"55 - 69 pkt- Ocena Dostateczna");
} else if(exam >= 70 && exam <= 84)
{
    Console.WriteLine($"70 - 84 pkt- Ocena Dobra");
} else if (exam >= 85 && exam >= 98)
{
    Console.WriteLine($"85 - 98 pkt- Ocena Bardzo Dobra");
} else if(exam >= 99 && exam <= 100)
{
    Console.WriteLine($"99 - 100 pkt- Ocena Celująca");
} else { Console.WriteLine("Wartość poza zakresem");

}

