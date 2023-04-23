// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int CountEvenNumbers(int [] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i ++)
    {
        if (massive [i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] MakeRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue,maxValue+1);
    }
    return massive;
}

int[] massive = MakeRandomArray(10, 100, 1000);
Console.Write($" [{String.Join(", ", massive)}] ->");
int count = CountEvenNumbers(massive);
Console.WriteLine($"{ count}");
