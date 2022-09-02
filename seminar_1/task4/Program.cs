//вводимое число
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//цикл for с уловием "Кратно 2"
for (int i = 1; i <= number; i++)
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }