int N = new Random().Next(2, 11); //some numbers from 2 to 11
int result = 1;
for (int i = 1; i <= N; i++)
{
result *= i;
}
Console.Write(N + " " + result); // show number and product of all its numbers