﻿int[] arr = new int[8];

for (int i = 0; i < 8; i++)
{
arr[i] = new Random().Next(2); // generate array of 0 and 1 randomly ordered // *no need to id starting point if it is zero (0, 2) = (2)
Console.Write(arr[i] + " ");
}

// or using the function below

int[] RandomArray(int N, int start, int end)
{
    int[] array = new int[N];
    for(int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}