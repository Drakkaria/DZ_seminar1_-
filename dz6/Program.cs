// Показать вторую цифру трёхзначного числа.

Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a/10%10;
Console.Write("второе число: ");
Console.WriteLine(b);