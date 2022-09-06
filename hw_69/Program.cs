Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{Pow(m,n)}");

int Pow(int number,int rank)
{
if (rank == 0) return 1;
return (number * Pow(number,rank-1));
}