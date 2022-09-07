//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84

int x1 = 3;
int y1 = 6;
int z1 = 8;
int x2 = 2;
int y2 = 1;
int z2 = -7;

void distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double d = Math.Round(Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5), 2);
    Console.WriteLine("Расстояние = " + d);
}

distance(x1, y1, z1, x2, y2, z2);