//вводимое число
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
//условие
if (number % 2 == 0)
{
    Console.Write(number);
    Console.Write(" - четное число");
}
else
{
    Console.Write(number);
    Console.Write(" - нечетное число");
}