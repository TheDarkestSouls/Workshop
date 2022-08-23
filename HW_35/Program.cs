// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

int sum(int[] a)
{
    int s = 0;
    for(int i = 0; i < a.Length; i++)
    {
        if(a[i] > 9 && a[i] < 100) s++;
    }
    return s;
}

int[] array123 = CreateRandomArray(123, 0, 180);
ShowArray(array123);
Console.WriteLine();
Console.WriteLine(sum(array123));