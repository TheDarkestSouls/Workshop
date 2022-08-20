                            // A raise to the power of B
                            
int a = Convert.ToInt32(new Random().Next(2, 9)); // random number from 2 to 9
int b = Convert.ToInt32(new Random().Next(2, 9)); // random number from 2 to 9
int temp = a;
Console.Write(a + " raise to the power of " + b + " equal ");

for(int i = 1; i < b; i++)
{
    a *= temp;
}
Console.Write(a);
