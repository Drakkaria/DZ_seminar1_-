﻿// Задача №27.
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

//1я пОпытка
// Console.Write("Здрасти! Введите число: ");
// int a = int.Parse(Console.ReadLine()!);
// int b = (a / 100) + (a /10 % 10) + (a % 10);                 // 452=4
// Console.Write("Сумма циферок: ");
// Console.WriteLine(b);

//2я пОпытка через ФОР

Console.Write("Введите число -> ");
int x = int.Parse(Console.ReadLine()!);
string string_x = Convert.ToString(x);

int summ = 0;

for (int i = 0; i < string_x.Length; i++)
{
   string a = Convert.ToString(string_x[i]);
   summ = summ + Convert.ToInt32(a);
}
Console.Write(summ);







