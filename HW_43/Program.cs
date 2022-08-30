// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

string[] F = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(F[0]);
double k1 = double.Parse(F[1]);
double b2 = double.Parse(F[2]);
double k2 = double.Parse(F[3]);

Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

double[] GetPoint(double A, double B, double C, double D)
{
    double[] result = new double[2];
    result[0] = (C - A) / (B - D);
    result[1] = B * result[0] + A;
    return result;
}