// 5. Показать последнюю цифру трёхзначного числа.

Console.WriteLine("Введите трех значное число");
int a = int.Parse(Console.ReadLine()!);
int b = a % 10;
Console.WriteLine(b);
