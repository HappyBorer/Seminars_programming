using static System.Console;
Clear();
/*Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/
// int[] array = { 4, 8, -8, -2 };

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] *= -1;
//     Console.Write($"{array[i]} ");
// }
// PrintArray(array);
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
/*Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да */

/*Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];*/
void RandomArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 124);
    }
}
/*RandomArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите число для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool flag = true;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    {
        Console.WriteLine($"Чило есть в массиве на позиции {i}");
        flag = false;
    }
}
if (flag)
{
    Console.WriteLine("Число отсутствует");
} */
/* int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}*/

int[] CreatArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}
/*Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0*/

/*int[] array = CreatArray(123);
int count = 0;
PrintArray(array);
WriteLine();
for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        count++;
    }
}
WriteLine(count);*/


/*Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/

int[] array = CreatArray(5);
PrintArray(array);
WriteLine();
int result = 0;
int sizz = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
/*if (array.Length % 2 == 0)
{
    sizz = array.Length / 2;
}
else
{
    sizz = array.Length / 2 + 1;
}*/
int[] arraySecond = new int[sizz];

for (int i = 0; i < sizz; i++)
{
    
    result = array[i] * array[array.Length - i - 1];

    arraySecond[i] = result;
    //Write($"{result} ");
}
if (array.Length % 2 != 0)
{
    arraySecond[arraySecond.Length - 1] = array[sizz - 1];

}
PrintArray(arraySecond);
