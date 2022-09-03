
int randomNum = new Random().Next(10, 1000000000);//Генерируем любое число от 10 до того сколько позволяет 32


void FindThree(int number)//создаем метод/функцию 
{
    if (number < 100)//Если меньше 3 цифр в числе то...
    {
        Console.WriteLine("Третьего числа нет");
    }
    else if (number < 1000)//Если ровно 3 цифр в числе то...
    {
        int firstNum = number % 100;
        int lastNumb = firstNum % 10;
        Console.WriteLine(lastNumb);
    }
    else// все остальные числа сюда
    {
        while (number > 999)
        {
            number = number / 10;
        }
        int lastNumb = number % 10;
        Console.WriteLine(lastNumb);
    }
}

Console.WriteLine(randomNum); //Выводим оригинальное число
FindThree(randomNum); //выводим его третью цифру если она есть, через функцию/метод