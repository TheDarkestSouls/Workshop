int N = new Random().Next(2, 11);

for (int i = 1; i <= N; i++)
{
int result = Convert.ToInt32(Math.Pow(i, 3));
Console.Write(result + " ");
}