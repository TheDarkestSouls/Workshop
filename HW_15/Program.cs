int num = Convert.ToInt32(Console.ReadLine());

if(num == 6 || num == 7)
{
    Console.WriteLine(" is weekend!");
}
else if (num > 0 && num < 6) 
Console.WriteLine(" is not weekend.");
else 
Console.WriteLine(" is not found in week.");
