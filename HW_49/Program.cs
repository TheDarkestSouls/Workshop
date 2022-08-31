Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, m];
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

for (int i = 2; i < array.GetLength(0); i+=2) // Square each number with both even index
{
for (int j = 2; j < array.GetLength(1); j+=2)
{
array[i, j] = array[i, j] * array[i, j];
}
}

Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++) // Output array
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write($" {array[i, j]}");
}
Console.WriteLine();
}