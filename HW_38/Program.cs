// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

void SelectionSort(int[] array)

{
    for(int i = 0; i < array.Length -1; i++) 
    {
        int minPosition = i; // minimal element by default

        for(int j = i + 1; j < array.Length; j++) 
        {
            if(array[j] < array[minPosition]) minPosition = j; // searching for the minimal element
        }

        int temp = array[i];            //  \
        array[i] = array[minPosition];  //   > change element of the current position for the minimal element in array
        array[minPosition] = temp;      //  /
    }
}

int diff(int[] array)
{
    int sum = 0;
    for(int i = array[0]; i < array[array.Length - 1]; i++)
    {
        sum++;
    }
    return sum;
}

int[] arr = CreateRandomArray(8, -99, 99);
ShowArray(arr);
SelectionSort(arr);
Console.WriteLine(diff(arr));