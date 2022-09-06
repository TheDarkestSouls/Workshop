//Задайте значение N. Напишите программу,
// //которая выведет все натуральные числа в промежутке от 1 до N.

Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

PrintNumbers(1,n);

void PrintNumbers(int start, int end)
{
Console.Write($"{start} ");
if (start == end) return;
PrintNumbers(start + 1, end);
}