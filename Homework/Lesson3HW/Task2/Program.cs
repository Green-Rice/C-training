// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
const int X = 0;
const int Y = 1;
const int Z = 2;

int[] inputCoords(string message)
{
    int[] numCoords = new int[3];
    for (int i = 0; i < numCoords.Length; i++)
    {
        System.Console.WriteLine($"{message} {i}-ю  ");
        string value = Console.ReadLine();
        numCoords[i] = int.Parse(value);
    }
    return numCoords;
}
double Power2FromPoint(double C1, double C2)
{
    double distanceCoords = C1 - C2;
    return distanceCoords * distanceCoords;
}
double LineLong(int[] point1, int[] point2)
{
    double longLine = Math.Sqrt(Power2FromPoint(point1[X], point2[X]) + Power2FromPoint(point1[Y], point2[Y]) + Power2FromPoint(point1[Z], point2[Z]));
    return longLine;
}
int[] point1 = inputCoords("Координаты первой точки");
int[] point2 = inputCoords("Координаты второй точки");
System.Console.WriteLine($"Растояние между  точками {LineLong(point1, point2)}");