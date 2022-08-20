int[] arr = new int[8];

for (int i = 0; i < 8; i++)
{
    arr[i] = int.Parse(Console.ReadLine()); // generate array of 0 and 1 randomly ordered
}
for(int i = 0; i < 8; i++)
{
    Console.Write(arr[i] + " ");
}