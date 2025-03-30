// See https://aka.ms/new-console-template for more information



/* INSTRUKCJE STERUJĄCE I PĘTLE */

// Zadanie 1
Console.WriteLine("Zadanie 1");
int n1 = 10, n2 = 20;

if (n1 <= n2)
{
    Console.WriteLine("n2 jest większe od n1 lub n1 jest równe n2");
}
else
{
    Console.WriteLine("Warunki zadania nie zostały spełnione");
}
Console.WriteLine("----------------------------------------------------------");

// Zadanie 2
Console.WriteLine("Zadanie 2");
string text = "C#";
int j = 1;

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i + ": " + text);
}
Console.WriteLine("----------------------------------------------------------");
while (j < 11) {  Console.WriteLine($"{j}: {text}");
j++;
};

// Zadanie 3

int n = 10;
for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} - Parzysta");
    }
    else
    {
        Console.WriteLine($"{i} - Nieparzysta");
    }
}


