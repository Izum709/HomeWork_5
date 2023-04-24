// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int SumNoEvenNumber(int[] massive)
{
    int result = 0;
    for(int i =1; i<massive.Length; i=i+2)
    {
        result = result + massive[i];
    }
    return result;

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

int[]massive = NewRandomMassive(4, -99, 99);
int sum = SumNoEvenNumber(massive);
Console.Write($"[{String.Join(", ", massive)}] -> {sum}");
