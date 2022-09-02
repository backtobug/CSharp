
//создаем рандомные числа c тремя цифрами
int RandomNum = new Random().Next(100, 1000);

//Создаем функцию/метод 
int cutMiddleNum(int num)
{
    int firstNum = num % 100;
    int middleNum = firstNum / 10;
    return middleNum;
}

//выводим рандомное число и результат метода
Console.WriteLine(RandomNum);
Console.WriteLine(cutMiddleNum(RandomNum));