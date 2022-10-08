/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/



void DistanceBetweenPoints(int xa, int ya, int za, int xb, int yb, int zb)
{
    double distance = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
    Console.Write($"A ({xa},{ya},{za}); B ({xb},{yb},{zb}) -> {distance}");
}

DistanceBetweenPoints(7, -5, 0, 1, -1, 9);