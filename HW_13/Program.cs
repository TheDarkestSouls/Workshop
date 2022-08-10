int num = Convert.ToInt32(Console.ReadLine());


while (num > 999)
{
    num /= 10;
}
if (num > 100)
{
    int result = num % 10;
    Console.WriteLine(result);
}
else Console.WriteLine("There is no 3rd number");
