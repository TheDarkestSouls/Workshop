// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int N, int start, int end)
{
int[] RandomArray = new int[N];
for (int i = 0; i < N; i++)
{
RandomArray[i] = new Random().Next(start, end + 1);
}
return RandomArray;
}

void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}

int sum(int[] array)
{
    int all = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) all += array[i];
    }
    return all;
}

int[] arr = CreateRandomArray(5, -20, 20); 
ShowArray(arr);
Console.WriteLine(sum(arr));



