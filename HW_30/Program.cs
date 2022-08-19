int[] arr = new int[8];

for (int i = 0; i < 8; i++)
{
arr[i] = new Random().Next(0, 2); // generate array of 0 and 1 randomly ordered
Console.Write(arr[i] + " ");
}