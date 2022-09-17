double[,] numbs = new double[2, 2];
double[] crossPoint = new double[2];

void InputNumbs()
{
    for (int i = 0; i < numbs.GetLength(0); i++)
    {
        Console.Write($"\nВведите данные прямой {i + 1}");
        for (int j = 0; j < numbs.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"\nВведите данные k: ");
            else Console.Write($"Введите данные b: ");
            numbs[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] ChekCrossPoint(double[,] numbs)
{
    crossPoint[0] = (numbs[1, 1] - numbs[0, 1]) / (numbs[0, 0] - numbs[1, 0]);
    crossPoint[1] = crossPoint[0] * numbs[0, 0] + numbs[0, 1];
    return crossPoint;
}

void ShowResult(double[,] numbs)
{
    if (numbs[0, 0] == numbs[1, 0] && numbs[0, 1] == numbs[1, 1])
    {
        Console.Write($"\nПрямые одинаковые");
    }
    else if (numbs[0, 0] == numbs[1, 0] && numbs[0, 1] != numbs[1, 1])
    {
        Console.Write($"\nПрямые параллельные");
    }
    else
    {
        ChekCrossPoint(numbs);
        Console.Write($"\nПрямые пересекаются в точке: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

InputNumbs();
ShowResult(numbs);
