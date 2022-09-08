// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {SumNumbers(M, N)}");

int SumNumbers(int x, int y)
{
    if (x == y) return x;
    return x + SumNumbers(x + 1, y);
}