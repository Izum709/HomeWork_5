// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int MaxMinDiff(int[] massive)
{
    int max = massive[0];
    int min = massive[0];
    for(int i = 0; i<massive.Length; i++)
    {
        if(max<massive[i]) max = massive[i];
        if(min>massive[i]) min = massive[i];
    }
    return max-min;
}


int[] NewRandomMassive(int size, int minValue, int maxValue)
{
    int[] massive = new int[size];
    for(int i =0;i <size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue+1);
    }
    return massive;
}

int[]massive = NewRandomMassive(5, 0, 99);
Console.Write($"[{String.Join(", ", massive)}] -> {MaxMinDiff(massive)}");