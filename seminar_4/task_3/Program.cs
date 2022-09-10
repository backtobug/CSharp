
int[] Createarray()
{
    Random rnd = new Random();
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int[] arr = Createarray();
Console.WriteLine(arr.Length);
PrintArray(arr);
