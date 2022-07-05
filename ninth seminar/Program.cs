using static System.Console;
Clear();

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}


/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */ 

// int number = int.Parse(Console.ReadLine());
// Console.WriteLine(NaturalNumber(number));

// int NaturalNumber(int number)
// {
//     if (number == 1)
//         return number;
//     else
//         Console.Write($"{NaturalNumber(number - 1)}, ");

//     return number;
// }

/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

// int m = InputInt("Задайте число m: ");
// int n = InputInt("Задайте число n: ");
// NaturalNumber(m, n);
 
// void NaturalNumber(int m, int n)
// {
//     if (m == n)
//     {
//         Console.Write($"{m} ");
//     } 
//     if (m < n)
//     {
//         Console.Write($"{m}, ");
//         NaturalNumber(m + 1, n);
//     }
//     if (m > n)
//     {
//         Console.Write($"{m}, ");
//         NaturalNumber(m - 1, n);
//     }
// }

// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }


// /* Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9 */
// // метод ввода чисел
// int InputNum(string msg)
// {
//     Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int NumberSum(int number)
// {
//     if(number < 0)
//         number = -number;

//     if(number == 0)
//         return 0;
    
//     return number % 10 + NumberSum(number/10);
// }


// int number = Input("Input number: ");
// Console.WriteLine(NumberSum(number));



/* Напишите программу, которая на вход принимает два числа A и B, и возводит число А возведенную в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

// int Power(int a, int b)
// {
//     if (b == 0)
//         return 1;

//     return a * Power(a, b - 1);
// }

// int A = InputNum("Input A: ");
// int B = InputNum("Input B: ");

// Console.WriteLine(Power(A, B));


// double Power(double a, int b)
// {

//     if (b == 0)
//         return 1;

//     if (b < 0)
//         return 1 / a * Power(a, b + 1);
//     else
//         return a * Power(a, b - 1);
// }

// int A = InputNum("Input A: ");
// int B = InputNum("Input B: ");

// Console.WriteLine(Power((double)A, B));














