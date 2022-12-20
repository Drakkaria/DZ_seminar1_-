/*Задача 1:
Напишите программу, которая принимает на вход число N и выдаёт сумму чисел от 1 до N.
7 -> 28
4 -> 10
8 -> 36
*/ 
/* 1 variant
Console.Write(" -> ");
double N = double.Parse(Console.ReadLine()!);
Console.Write((1 + N) * (N / 2));
*/
/* 2 variant
Console.Write("Введите число N ");
int N = int.Parse(Console.ReadLine());
int sum = 0;
for (int i=1; i<=N; i++) 
{
sum=sum+i;
}
Console.Write(sum);
*/

/*Задача 2:
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4  -> 24
5  -> 120

Задача 3 (общая):
Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
int[] Array =new int[8];
for (int i=0; i<Array.Length; i++) 
{
    
Array[i] = new Random().Next(0,2);
Console.Write(","+Array[i]);

}


