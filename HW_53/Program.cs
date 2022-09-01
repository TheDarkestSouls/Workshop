// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
ChangeRows(array);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
int[,] result = new int[m, n];
for (int i = 0; i < m; i++)
{
for (int j = 0; j < n; j++)
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
void ChangeRows(int[,] inArray)
{
int rowCount = inArray.GetLength(0) - 1;
for (int i = 0; i < inArray.GetLength(1); i++)
{
int k = inArray[0, i];
inArray[0, i] = inArray[rowCount, i];
inArray[rowCount, i] = k;
}
}