// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine());
int[,] Array = GetArray(rows, columns, 0, 10);
PrintArray(Array);

Console.WriteLine($"Row with minimal sum of all elements is {GetRowNumber(Array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int GetRowNumber(int [,] array)
{
    int row = 0;
    int minsum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        minsum += array[0, i];
    }

    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if(minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}


















//  // Create random array

// int[] CreateRandomArray(int N, int start, int end)
// {
// int[] RandomArray = new int[N];
// for (int i = 0; i < N; i++)
// {
// RandomArray[i] = new Random().Next(start, end + 1);
// }
// return RandomArray;
// }

// // Create array manually

// int[] CreateArray()
// {
// Console.WriteLine("Введите количество элементов массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// Console.WriteLine($"Введите {i+1} элемент массива");
// array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }

// // Output array

// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }

// // Get array from string

// int[] GetArrayFromString(string stringArray)
// {
//     string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//     int[] result = new int[numS.Length];
//     for(int i = 0; i < result.Length; i++)
//     {
//         result[i] = int.Parse(numS[i]);
//     }
//     return result;

// }

// // Program example

// Console.Clear();
// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);

// // Another one method to output an array

// Console.WriteLine($"[{String.Join(", ", myArray)}]");

// // Split and Replace function

// string text = "(1,2) (2,3) (4,5) (6,7)"
//                 .Replace("(", "")
//                 .Replace(")", "")
//                 ;
// var data = text.Split(" ")

//                 .ToArray();

// for(int i = 0; i < data.Length; i++)
// {
//     Console.WriteLine(data[i]);
// }
