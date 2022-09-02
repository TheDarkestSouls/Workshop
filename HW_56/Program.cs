// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[3, 5];

for (int i = 0; i < array.GetLength(0); i++) // Generate random array
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 9);
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

PrintArray(array);

int rowSum = 0;
int rowSum1 = 0;
for (int i = 0; i < array.GetLength(0) + 2; i++)
{
    rowSum += array[0, i];
    for(int j = i + 1; j < array.GetLength(0) + 2; i++)
    {       
        {

        }
    }
}
Console.WriteLine(rowSum);





