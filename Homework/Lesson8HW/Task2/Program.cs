// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] Fill2DArray(int lines, int columns, int min, int max)     //Заполнение массива
{
    int[,] array = new int[lines, columns];
    for (int i = 0; i < array.GetLength(0); i++)     //Проход по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)     //Проход по колонкам
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
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

int SearchSmallestLine(int[,] array)
{
    int line = 0;
    int result = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма чисел в строке {i + 1} = {sum}");
        if (sum <= result || result == 0)
        {
            result = sum;
            sum = 0;
            line = i + 1;
        }
    }
    return line;
}
int[,] array = Fill2DArray(4, 4, 1, 10);
Print2DArray(array);
Console.WriteLine();
System.Console.WriteLine($"Строка с наименьшей суммой элементов : {SearchSmallestLine(array)}");