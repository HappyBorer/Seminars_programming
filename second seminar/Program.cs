/*string DoubFig (int a)
{
    int figure3 = a % 10;
    string figure33 = Convert.ToString(figure3);
    int figure1 = a / 100;
    string figure11 = Convert.ToString(figure1);
    return figure11 + figure33;
}
Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);

Console.WriteLine(DoubFig(number));*/
/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли первое число кратным второму. Если число 1 не кратно числу 2, 
то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно*/

/* Console.Clear();
Console.Write("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 % number2 != 0)
{
    int result = number1 % number2;
    Console.WriteLine($"не кратно, {result}");
}
else
{
    Console.WriteLine("кратно");
}
 Напишите программу, которая принимает на вход число и проверяет,
 кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да */
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

/* Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет */






