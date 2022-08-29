// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1, k1, b2, k2;
Console.WriteLine("Enter the b1: "); b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the k1: "); k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the b2: "); b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the k2: "); k2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"{b1}, {k1}, {b2}, {k2}");

double[] getPoint = {b1, k1, b2, k2};

double[] CrossPoint(double a, double b, double c, double d)
{
    double[] result = new double[2];
    result[0] = (c - a)/(b - d);
    result[1] = b * result[0] + a;
    return result;

}

Console.WriteLine(CrossPoint(b1, k1, b2, k2));
