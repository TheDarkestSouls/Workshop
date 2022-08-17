int N = new Random().Next(2, 11);
int result = 1;
for (int i = 1; i <= N; i++)
{
result *= i;
}
Console.Write(N + " " + result);