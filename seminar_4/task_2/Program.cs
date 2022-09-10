Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int number)
{
    int count = Convert.ToString(number).Length;
    int temp = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        temp = number % 10;
        result = result + temp;
        number = number / 10;
    }
    return result;
}
Console.WriteLine($"Сумма цифр в числе = {SumNum(number)}");
