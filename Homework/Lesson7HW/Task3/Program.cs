﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArray(int[,] array)
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
void AverageColumns(int[,] array)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result += array[j, i];
        }
        System.Console.WriteLine($"Среднее арифметическое {i+1} столбце = {Math.Round(result/array.GetLength(0), 1)}");
        result = 0;
    }
}

    void FillArray(int[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 10);
            }
        }

    }

int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
AverageColumns(array);
