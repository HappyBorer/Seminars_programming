using static System.Console;
Clear();

/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* 
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
int count = 0;

// Вариант решения через while

// while(number > 0)
// {
//     number /= 10;
//     count++;
// }
// WriteLine($"В числе цифр - {count}");

// Вариант решения через for

for (int i = number; i > 0; i /= 10)
{
    count++;
}
WriteLine($"В числе цифр - {count}"); */

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

/* Write("Введите число N: ");
int numberN = Convert.ToInt32(ReadLine());

// Вариант решения через while

// int count = 1;
int work = 1;
// while (count <= numberN)
// {
//     work *= count;
//     count++;
// }
// WriteLine($"Фактариал чмсла {numberN} равен {work}");

// Выриант решения с for

for(int i = 1; i <= numberN; i++)
{
    work *= i;
}
 WriteLine($"Фактариал чмсла {numberN} равен {work}"); */

/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(2);
    if(i < array.Length - 1)
    {
        Write($"{array[i]}, ");
    }
    else
    {
        Write($"{array[i]}.");
    }
}



