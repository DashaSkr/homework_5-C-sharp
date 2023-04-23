//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int CountDifferenceMaxMin(int [] massive)
{
    int min = massive [0];
    int max = massive [0];
    int diff = max - min;
    for (int i = 1; i < massive.Length; i ++)
    {
        if (massive [i] > max)
        {
            max = massive [i];
        }   
        if (massive [i] < min)
        {
            min = massive [i];
        }   
        diff = max - min;
    }
    return diff;
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

int[] massive = MakeRandomArray(10, 1, 100);
Console.Write($" [{String.Join(", ", massive)}] ->");
int diff = CountDifferenceMaxMin(massive);
Console.WriteLine($" {diff}");
