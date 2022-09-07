
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

void GetCube(int n)
{
    while (count != Math.Abs(number) + 1)
    {
        Console.WriteLine($"Куб числа {count} = {count * count * count}");
        count++;
    }
}

GetCube(number);