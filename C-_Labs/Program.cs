// See https://aka.ms/new-console-template for more information



/* OPERATORY */


// Zadanie 2

string myAge = "Age: ";
int wifeAge = 18;
string result = myAge + wifeAge;
Console.WriteLine(result);

/* Żeby łączyć zmienne, w tym przypadku string z integer, można użyć operatora +. */

// Zadanie 3

bool isTrue = true;
bool isFalse = false;
bool isReallyTrue = true;

bool and = isTrue && isFalse;
bool or = isTrue || isFalse;
bool negative = !isFalse;

Console.WriteLine($"Zmienne logiczne: {and}, {or}, {negative}");

// Zadanie 4

int a = 5;
int b = 12;
int add = a + b;
int sub = a - b;
int mul = a * b;
int div = a / b;
int mod = a % b;
Console.WriteLine($"Wyniki działań matematycznych: dodawanie - {add}, odejmowanie - {sub}, mnożenie - {mul}, dzielenie - {div}, modulo - {mod}");

