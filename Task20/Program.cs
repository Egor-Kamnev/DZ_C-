// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double DistanceAB(int xa, int ya, int xb, int yb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    return distAB;
}

Console.WriteLine("Введите координаты точки A:");
Console.WriteLine("Xa = ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ya = ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
Console.WriteLine("Xb = ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Yb = ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xACoordinate, yACoordinate, xBCoordinate, yBCoordinate);
double distRound = Math.Round(distanceAB, 2 ,MidpointRounding.ToZero);
Console.WriteLine(distRound);