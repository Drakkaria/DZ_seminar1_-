// Задача №25.
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число A ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B ");
int b = int.Parse(Console.ReadLine()!);
int cocos = a;
while (i < b)
{
    cocos = cocos * A;
    i++;
}
Console.Write("A в степени B равно" + cocos);