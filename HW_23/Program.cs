// Cube numbers from 1...N

Console.Write("Enter the number: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine();
for(int i = 1; i <= N; i++) // cycle
{
    Console.WriteLine(Math.Pow(i, 3)); // cube
    Console.WriteLine();
}