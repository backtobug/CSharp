//первое вводимое число
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
//второе вводимое число
Console.Write("Введите первое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
//третье вводимое число
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

//условие , если какоето число в переменной, больше чем число в переменной num1, num1 принимает это число
if (num1 < num2)
{
    num1 = num2;
}
if (num1 < num3)
{
    num1 = num3;
}
Console.Write("Самое большое число из трех: ");
Console.Write(num1);