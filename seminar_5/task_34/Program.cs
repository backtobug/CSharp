
int[] array = new int[4];


void GetRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1} Число в массиве {array[i]}");
    }
}

void FindEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Колличество четных чисел в массиве: {count}");
}

GetRandomArray(array);
PrintArray(array);
FindEven(array);