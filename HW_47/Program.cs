// Задача 47. Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Enter the amount of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the amount of columns: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = getArray(rows, columns);
PrintArray(array);

double[,] getArray(int m, int n)
{
    double[,] result = new double[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 10;
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
