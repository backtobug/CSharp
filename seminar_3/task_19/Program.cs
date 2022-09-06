
Console.Write("Введите число из 5 цифр: ");
string? randomNum = Console.ReadLine();

if (randomNum!.Length == 5) // если в числе 5 цифр запускаем
{
    isPolindrom(randomNum);
}
else Console.WriteLine("Число не состоит из 5 цифр");

void isPolindrom(string number)
{
    if (number[0] == number[4] & number[1] == number[3])
    {
        Console.WriteLine($"Число: {number} - является палиндромом.");
    }
    else Console.WriteLine($"Число: {number} - не является палиндромом.");
}
