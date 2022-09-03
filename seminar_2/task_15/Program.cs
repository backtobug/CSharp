int randomNum = new Random().Next(1, 8);//Генерируем любое число от 1 до 8
int[] weekend = { 6, 7 };//создаем массив с выходными днями

void itsWeekend(int num)//создаем метод/функцию с проверкой дня на выходной
{
    if (num == weekend[0] || num == weekend[1])
    {
        Console.WriteLine("Да, выходной");
    }
    else
    {
        Console.WriteLine("Нет, не выходной");
    }
}
Console.WriteLine(randomNum);//выводим день
itsWeekend(randomNum);//выводим результат проверки