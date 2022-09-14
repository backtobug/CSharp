int[] array = new int[4];

void GetRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1} Число в массиве {array[i]}");
    }
}

void FindMinMax(int[] array)
{
    int min = array[1];
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} числом равна = {max - min}");
}
GetRandomArray(array);
PrintArray(array);
FindMinMax(array);
