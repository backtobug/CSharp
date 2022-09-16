
Console.Write($"Введи сколько будет чисел в массиве: ");
int collectionSize = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[collectionSize];

void AddNumbers(int collectionSize)
{
    for (int i = 0; i < collectionSize; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int NullComparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

AddNumbers(collectionSize);
Console.WriteLine($"В массиве чисел больше 0: {NullComparison(massiveNumbers)}");
