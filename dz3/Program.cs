// Задача №3. 
// Найти максимальное из трех чисел.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int с = int.Parse(Console.ReadLine()!);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (с > max) max = с;

string str = $"Максимальное число = {max}." ;
Console.WriteLine(str);

