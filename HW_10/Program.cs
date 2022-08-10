int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{

    // int temp = num % 100;
    // int result = temp / 10;

    // Console.WriteLine(result);

    Console.WriteLine((num % 100) / 10);
}
else Console.WriteLine("Something wrong...");