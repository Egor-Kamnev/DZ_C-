// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;

    int deltaY = ya - yb;

    int deltaZ = za - zb;

    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

    return distAB;
}

Console.WriteLine("Введите координаты точки A:");

Console.WriteLine("Xa = ");
int xACoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ya = ");
int yACoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Za = ");
int zACoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");

Console.WriteLine("Xb = ");
int xBCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yb = ");
int yBCoord = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Zb = ");
int zBCoord = Convert.ToInt32(Console.ReadLine());

double distAB = DistAB(xACoord, yACoord, zACoord, xBCoord, yBCoord, zBCoord);

double distRound = Math.Round(distAB, 2, MidpointRounding.ToZero);

Console.WriteLine(distRound);