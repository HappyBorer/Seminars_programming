/*Задача 18: Напишите программу, которая по заданному номеру четверти,
 показывает диапазон возможных координат точек в этой четверти (x и y).*/

/*using static System.Console;
Clear();
int Q = Input("Введите четверть:");
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

if (Q == 1)
{
    WriteLine($"x = {int.MaxValue}  и y > 0");
}
else if (Q == 2)
{
    WriteLine("x < 0  и y > 0");
}
else if (Q == 3)
{
    WriteLine("x < 0  и y < 0");
}
else if (Q == 4)
{
    WriteLine("x > 0  и y < 0");
}
else
{
    WriteLine("Ошибка");
}*/

/*Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

/*int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
int x1 = Input("Введите x1:");
int y1 = Input("Введите y1:");
int x2 = Input("Введите x2:");
int y2 = Input("Введите y2:");

double lengthPer = Math.Sqrt(Math.Pow((double)(x1 - x2), 2) + Math.Pow((double)(y1 - y2), 2));

Console.WriteLine(lengthPer);*/

/*Задача 22: Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

/*using static System.Console;
Clear();
int Square (int a)
{
    return a * a;
}
int n = Convert.ToInt32(ReadLine());
int count = 1;
while(count <= n)
{
    if(count == n)
    {
        Write(Square(count));
        return;
    } 
    Write(Square(count) + ",");
    count++;
}*/


using static System.Console;
Clear();

