// Удалить вторую цифру трёхзначного числа.

//Console.WriteLine("Введите трехзначное число");
//int a = int.Parse(Console.ReadLine()!);
//int b = a / 100 * 10 + a % 10;  // 589/100=5, 589%10=9, 
//Console.WriteLine(b);

Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b = a / 100;
int c = a % 10;
if (a > 99 && a < 1000) 
{
Console.Write(b);
Console.Write(c);
}
else Console.Write("Алло, читай вниметельно да! Это не трехзначное число!");
