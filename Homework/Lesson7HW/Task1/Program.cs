// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] FillArray(int line, int columns, int min, int max)
{
    double[,] array = new double[line, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max)/10.0;
        }
    }
    return array;
}

double[,] array = FillArray(Prompt("Введите колличество строк :"), Prompt("Введите колличество столбиков :"), -100, 100);
PrintArray(array);
