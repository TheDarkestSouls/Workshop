// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
Console.Write($" {array[i, j]} ");
}
Console.WriteLine();
}


for(int i = 0; i < array.GetLength(1); i++)
{
    double sumColumn = 0;
    for(int j = 0; j < array.GetLength(0); j++)
    {
        sumColumn += array[j, i];
    }
    Console.Write($"{sumColumn/array.GetLength(1)} ");
}