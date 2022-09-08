// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

PrintNumbers(M, N);

int PrintNumbers(int x, int y)
{
    int sum = 0;
    if (sum == y) return sum;
    sum += x;
    PrintNumbers(1, y);
}