using static System.Console;
Clear();


//double a = Convert.ToDouble(new Random(100, 100) / 10);



// Console.Write("Введите число от 0 до 15: ");
// int a = Convert.ToInt32(Console.ReadLine());

// string b = a switch
// {
//     > 0 and < 10 => Convert.ToString(a),
//     10 => "A",
//     11 => "B",
//     12 => "C",
//     13 => "D",
//     14 => "E",
//     15 => "F",
//     _ => "Мы не умеем переводить такие числа"
// };
// WriteLine(b);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

// Задача 40:Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
// с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

// int a = Input("Введите первое число: ");
// int b = Input("Введите второе число: ");
// int c = Input("Введите третье число: ");

// if ( a < b+c && b < a+c && c < b+c) 
// {
//      Console.Write("Треугольник возможен");
// }
// else Console.Write("Треугольник НЕвозможен");

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

//int number = Input("Введите число: ");
// string digit = String.Empty;

// while(number  > 0)
// {
//     digit = number % 2 + digit;
//     number /= 2;
// }

// WriteLine(digit);

// int size = 0;
// for (int i = number; i > 0; i /= 2)
// {
//     size++;
// }
// int[] numbersArr = new int[size];

// for (int i = numbersArr.Length - 1; i >= 0; i--)
// {
//     numbersArr[i] = number % 2;
//     number /= 2;
// }
// PrintArray(numbersArr);

/*Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8*/
// int N = Input("Введите число: ");
// int[] numbers = new int[N];


// if (N > 2)
// {
//     numbers[0] = 0;
//     numbers[1] = 1;
//     for (int i = 2; i < numbers.Length; i++)
//     {
//         numbers[i] = numbers[i - 1] + numbers[i - 2];
//     }
//     Write($"Если N = 5 -> ");
//     PrintArray(numbers);
// }
// else if (N == 1)
// {
//     Write(numbers[0]);
// }
// else if (N == 2){ 
//     Write(0 + " " + 1);
// }
// else Write("Ошибка");


/*Задача 45: Напишите программу, которая будет создавать 
копию заданного массива с помощью поэлементного копирования.*/


int[] numbers = {1, 4, 5, 6};
int[] numbers2 = new int[numbers.Length];

for(int i = 0; i < numbers.Length; i++)
{
    numbers2[i] = numbers[i];
}
PrintArray(numbers2);

