// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] array = new int[5, 5];

for (int i = 0; i < array.GetLength(0); i++) // Generate random array
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(0, 9);
}
}

for (int i = 0; i < array.GetLength(0); i++) // Output array
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($" {array[i, j]}");
}
Console.WriteLine();
}

Console.WriteLine("Enter row number: ");
int Index1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter column number: ");
int Index2 = int.Parse(Console.ReadLine());

if(Index1 < array.GetLength(0) && Index2 < array.GetLength(1))
{
    Console.WriteLine(array[Index1,Index2]);
}
else
{
    Console.WriteLine("There is no such element in array");
}


