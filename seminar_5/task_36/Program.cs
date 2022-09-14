int[] array = new int[4];

void GetRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i} индекс в массиве {array[i]}");
    }
}

void SumOfOddIndices(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма чисел в нечетных индексах: {sum}");
}
GetRandomArray(array);
PrintArray(array);
SumOfOddIndices(array);