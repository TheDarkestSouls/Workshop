// 48
Console.Clear();

Console.WriteLine("Enter the amount of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the amount of columns: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = getArray(rows, columns, 0, 10);
PrintArray(array);

int[,] getArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
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
