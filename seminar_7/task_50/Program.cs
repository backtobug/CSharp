int rows = ReadInt("Введите номер строки: ");
int colums = ReadInt("Введите номер столбца: ");
int[,] numbers = new int[6, 8];
FillArray2D(numbers);
PrintArray2D(numbers);

if (rows < numbers.GetLength(0)
    && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
else Console.WriteLine($"{rows}{colums} -нет такого числа в массиве");

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}