// Is number palindrome or not
int n, r, sum = 0, temp; // n = number, r = right symbol of the number, sum = mirror of the number, temp = temporal integer
Console.Writeline("Enter the Number: ");
n = Convert.ToInt32(Console.Readline());
temp = n;
while (n > 0)
{
    r = n % 10; // finding the right symbol
    sum = (sum * 10) + r; // assembling the mirror
    n = n / 10; // cutting the right symbol
}
if (temp == sum)
Console.Writeline("Number is Palindrome");
else 
Console.Writeline("Number is not Palindrome");

