// Напишите программу, которая принимает на вход 
// 1. координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A ");
Console.Write("Xa: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Ya: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Za: ");
int zACoordinate = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите координаты точки B ");
Console.Write("Xb: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Yb: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Zb: ");
int zBCoordinate = Convert.ToInt32(Console.ReadLine());


double Decision(double xACoordinate, double xBCoordinate,
                double yACoordinate, double yBCoordinate,
                double zACoordinate, double zBCoordinate)
{
    return Math.Sqrt(Math.Pow((xBCoordinate - xACoordinate), 2) +
                     Math.Pow((yBCoordinate - yACoordinate), 2) +
                     Math.Pow((zBCoordinate - zACoordinate), 2));
}

double segmentLength = Math.Round(Decision(xACoordinate, xBCoordinate, yACoordinate, yBCoordinate, zACoordinate, zBCoordinate), 2);

Console.WriteLine($"Длина отрезка {segmentLength}");
