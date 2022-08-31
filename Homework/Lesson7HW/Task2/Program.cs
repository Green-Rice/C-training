// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] FillArray(int line, int columns, int min, int max)
{
    int[,] array = new int[line, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

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

bool IndexCheck(int[,] array, int line, int column)
{
    bool result = true;
    if (array.GetLength(0) <= line || array.GetLength(1) <= column)
    {
        result = false;
    }
    return result;
}

void FindingElementArray(int[,] array, int line, int column)
{
    if (IndexCheck(array, line, column))
    {
        System.Console.WriteLine(array[line, column]);
    }
    else
    {
        System.Console.WriteLine("Элемента нет.");
    }
}

int [,]array = FillArray(4,5,1,100);
PrintArray(array);
FindingElementArray(array, Prompt("Введите номер строки =>"), Prompt("Введите номер столбца =>"));
