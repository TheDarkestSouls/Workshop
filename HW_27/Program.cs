// Sum of numbers...in the number

Console.WriteLine("Enter the number: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
double temp = 0; // using double for math
if (n < 0) // converting - to +
{
    temp = Math.Pow(n, 2);
    n = Convert.ToInt32(Math.Sqrt(temp));
}
while (n > 9) // separate and summarize numbers
{
    sum += n % 10;
    n /= 10;
}
sum += n;
Console.Write(sum);