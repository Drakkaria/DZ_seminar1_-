// 2. По заданному номеру дня недели вывести его название.

Console.Write("Введите число номер дня недели ");
int day = int.Parse(Console.ReadLine()!);

int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 5;
int f = 6;
int g = 7;

if(day == a)
{
    Console.WriteLine ("понедельник");
}
if(day == b)
{
    Console.WriteLine ("вторник");
}
if(day == c)
{
    Console.WriteLine ("среда");
}
if(day == d)
{
    Console.WriteLine ("четверг");
}
if(day == e)
{
    Console.WriteLine ("пятница");
}
if(day == f)
{
    Console.WriteLine ("суббота");
}
if(day == g)
{
    Console.WriteLine ("воскресение");
}

