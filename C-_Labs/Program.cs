// See https://aka.ms/new-console-template for more information



/* KOLEKCJE */

// Zadanie 1
Console.WriteLine("KOLEKCJE");
Console.WriteLine("Zadanie 1");
string[] colors = { "Niebieski", "Biały", "Żółty", "Czerwony" };

Console.WriteLine($"Mój pierwszy kolor to: {colors[0]}");
Console.WriteLine($"Mój pierwszy kolor to: {colors[3]}");

// Zadanie 2
Console.WriteLine("-------------------------------------------------------------");
Console.WriteLine("Zadanie 2");
int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"Liczba: {nums[i]}");
}

int j = 0;
while (j < nums.Length)
{
    Console.WriteLine($"Liczba: {nums[j]}");
    j++;
}
Console.WriteLine("-------------------------------------------------------------");
// Zadanie 3
List<string> fruits = new List<string>();
fruits.Add("Jabłko");
fruits.Add("Gruszka");
fruits.Add("Śliwka");
fruits.Add("Arbuz");

foreach (var fruit in fruits)
{
    Console.WriteLine($"Owoce: {fruit}");
}
 Console.WriteLine("==============================================================");
fruits.Remove("Jabłko");
fruits.RemoveAt(2);

foreach (var fruit in fruits)
{
    Console.WriteLine($"Owoce: {fruit}");
}
