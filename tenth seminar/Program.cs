using static System.Console;
Clear();

/* Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих. 
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26 */

int InputInt(string consoleMessage)
{
    Console.Write($"Insert {consoleMessage}: ");
    return Convert.ToInt32(Console.ReadLine());
}


int Fibonacci(int a, int b, int count)
{
    if (count == 0)
    {
        return a; 
    }
    if (count == 1)
    {
        return a;
    }
    if (count == 2)
    {
        return b;
    }
    else
    {
        return Fibonacci(a, b, count - 1) + Fibonacci(a, b, count - 2);
    }
    return 0;


}

int beginNum = InputInt("first number");
int secondNum = InputInt("second number");
int count = InputInt("count");

for (int i = 1; i <= count; i++)
{
    Console.Write(Fibonacci(beginNum,secondNum,i)+"  ");
}



/* В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
ав, ва, ви, ив, св, вс */

// string charsWords = "аисв";
// int countCharsInWords = 3;
// PrintAllWords(charsWords,countCharsInWords,"");

// void PrintAllWords(string alphabet, int length, string prefix)
// {
//     if (length == 0)
//     {
//         Console.Write(prefix + " ");
//     }
//     else
//     {
//         for (int i = 0; i < alphabet.Length; i++)
//         {
//             PrintAllWords(alphabet,length-1,prefix + alphabet[i]);
//         }
//     }
// }

// string alphabet = "аисв";
// int n = 2;

// void FindWords(string alph, char[] word, int length = 0)
// {
//     if (length == word.Length)
//     {
//         Console.Write(new String(word)+ "  ");
//     }
//     else
//     {
//         for (int i = 0; i < alph.Length; i++)
//         {
//             word[length] = alph[i];
//             FindWords(alph, word, length + 1);
//         }
//     }
// }

// FindWords(alphabet, new char[n]);

/* Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). 
В массиве data хранится информация о количестве бит, которые занимают числа из массива info. Напишите программу, 
которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1*/

// int[] info = { 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1 };
// int[] data = { 3, 3, 2, 4, 1, 2, 3, 3 };

// int[] result = new int[data.Length];
// int currentPosition = 0;
// for (int i = 0; i < data.Length; i++)
// {
//     for (int j = currentPosition; j < currentPosition + data[i] ; j++)
//     {
//         result[i] += info[j] * (int)Math.Pow(2, currentPosition+data[i]-j-1);
//     }
//     currentPosition += data[i];
// }
// PrintArray(result);



// void PrintArray(int[] arrayForPrint)  //печать массива
// {
//     Console.Write("[");
//     for (int i = 0; i < arrayForPrint.Length - 1; i++)
//     {
//         Console.Write(arrayForPrint[i] + ", ");
//     }
//     Console.Write(arrayForPrint[arrayForPrint.Length - 1] + "]");
//     Console.WriteLine();
// }


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

int[] decimalNumbers = GetNumbersFromDataInfo(data, info);

Console.Write("data = ");
PrintArray(data);

Console.Write("info = ");
PrintArray(info);

Console.Write("result = ");
PrintArray(decimalNumbers);


int GetDecimal(int[] bits, int minIdx, int maxIdx)
{
  int number = 0;
  for (int i = minIdx; i < maxIdx + 1; i++)
  {
    number += bits[i] * (int)Math.Pow(2, maxIdx - i);
  }
  return number;
}

int[] GetNumbersFromDataInfo(int[] bits, int[] sizes)
{
  int[] numbers = new int[sizes.Length];

  int startIdx = 0;
  int endIdx = -1;
  for (int i = 0; i < numbers.Length; i++)
  {
    startIdx = endIdx + 1;
    endIdx = endIdx + sizes[i];
    int number = GetDecimal(bits, startIdx, endIdx);
    numbers[i] = number;
  }

  return numbers;
}

void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}



