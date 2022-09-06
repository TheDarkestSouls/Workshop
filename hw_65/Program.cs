
Console.Clear();
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

PrintNumbers(M, N);

void PrintNumbers(int x, int y)
{
Console.Write($"{x} ");
if (x == y) return;
PrintNumbers(x + 1, y);
}