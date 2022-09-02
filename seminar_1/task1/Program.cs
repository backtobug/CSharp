//первое вводимое число
Console.Write("Введите первое число: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
//второе вводимое число
Console.Write("Введите первое число: ");
int numSecond = Convert.ToInt32(Console.ReadLine());

//условие
if (numFirst > numSecond)
{
    Console.Write("Первое число больше второго");
}
else if (numFirst < numSecond)
{
    Console.Write("Второе число больше первого");
}
else
{
    Console.Write("Числа одинаковые");
}




