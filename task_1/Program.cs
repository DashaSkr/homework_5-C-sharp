// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int CountSumUnevenElements(int [] massive)
{
    int count = 0;
    for (int i = 1; i < massive.Length; i = i +2)
    {
        count = count + massive [i];
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

int[] massive = MakeRandomArray(10, 1, 100);
Console.Write($" [{String.Join(", ", massive)}] ->");
int sum = CountSumUnevenElements(massive);
Console.WriteLine($" {sum}");