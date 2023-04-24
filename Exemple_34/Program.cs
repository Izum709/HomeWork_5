// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int SumEvenNumber(int[] massive)
{
    int sum = 0;
    for( int i =0;  i < massive.Length; i++)
    {
        if(massive[i]%2==0) sum +=1;
    }
    return sum;
}
 
 int[] MakeRandomArray(int size, int minValue, int maxValue)
 {
    int[] massive = new int[size];
    for(int i = 0; i<size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue+1);
    }
    return massive;
 }

 int[] massive = MakeRandomArray(4, 100, 998);
 Console.Write($"[{String.Join(", ",massive)}] -> ");
 int sum = SumEvenNumber(massive);
 Console.WriteLine(SumEvenNumber(massive));