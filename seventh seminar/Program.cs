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
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// int m = Input("Введите m: ");
// int n = Input("Введите n: ");

// int[,] numbers = new int[m, n];

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for(int j = 0; j < numbers.GetLength(1); j++)
//     {
//         numbers[i, j] = new Random().Next(1, 10);
//     }
// }

// PrintArray(numbers);

/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5*/

// int m = Input("Введите m: ");
// int n = Input("Введите n: ");

// int[,] numbers = new int[m, n];

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for(int j = 0; j < numbers.GetLength(1); j++)
//     {
//         numbers[i, j] = i + j;
//     }
// }

// PrintArray(numbers);


/*Задача 49:Задайте двумерный массив. Найдите элементы, 
у которых оба индекса нечётные, и замените эти элементы на их квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4*/


// int m = Input("Введите m: ");
// int n = Input("Введите n: ");

// int[,] numbers = new int[m, n];

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for(int j = 0; j < numbers.GetLength(1); j++)
//     {
    
//         numbers[i, j] = new Random().Next(1, 10);
//     }
// }

// PrintArray(numbers);
// WriteLine();

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for(int j = 0; j < numbers.GetLength(1); j++)
//     {
//         if(i % 2 != 0 && j % 2 != 0)
//         {
//            numbers[i, j] *= numbers[i, j];
//         }
//     }
// }

// PrintArray(numbers);

/*Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] numbers = new int[m, n];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
    
        numbers[i, j] = new Random().Next(1, 10);
    }
}

PrintArray(numbers);
WriteLine();
int result = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        if(i == j )
        {
           result += numbers[i, j];
        }
    }
}

Console.WriteLine(result);

