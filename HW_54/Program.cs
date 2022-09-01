// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = new int[5, 5];

for (int i = 0; i < array.GetLength(0); i++) // Generate random array
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 9);
    }
}

PrintArray(array);
SelectionSort(array);
Console.WriteLine();
PrintArray(array);

void SelectionSort(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            int maxPosition = i;

            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, j] > array[k, maxPosition]) maxPosition = j;
            }

            int temp = array[k, i];
            array[k, i] = array[k, maxPosition];
            array[k, maxPosition] = temp;
        }
    }
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
