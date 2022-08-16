// Distance beetween 3d objects

int coordinates(int dot = 0) // method
{
    dot = int.Parse(Console.ReadLine());
    return dot;
}
Console.WriteLine("Enter 3d coordinates of the Object1");
int a1 = coordinates(); int b1 = coordinates(); int c1 = coordinates();

Console.WriteLine("Enter 3d coordinates of the Object2");
int a2 = coordinates(); int b2 = coordinates(); int c2 = coordinates();

Console.Write("The distance beetween Object1 and Object2 is ");
Console.WriteLine(Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1) + (c2 - c1) * (c2 - c1))); // mathematic formula