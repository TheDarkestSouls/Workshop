Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int [,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = new Random().Next(-10, 10);
}
}

int min = 0;
if (rows<columns)
{
min = rows;
}
else
{
min = columns;
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}

int sum = 0;
for (int i = 0; i < min; i++)
{
sum += matrix[i,i];
}

Console.Write(sum);