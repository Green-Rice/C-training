// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4   В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] FillArray(int line, int columns, int max=20, int min= 0)     //Заполнение массива
{
    int[,] array = new int[line, columns];
    for (int i = 0; i < array.GetLength(0); i++)     //Проход по строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)     //Проход по колонкам
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] BubbleSortLine(int[,] array)   //Функция пузырьковой сортировки строк по на убывание
{
    for (int i = 0; i < array.GetLength(0); i++)    //Цикл запускающий сортировку по строкам
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)     //Колличество проходов
        {
            bool flagSort = true;
            for (int j = 0; j < array.GetLength(1) -1 - k; j++)     //Цикл продвижения внутри строк
            {
                if (array[i, j] < array[i, j + 1])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    flagSort=false;

                }
            }
            if(flagSort){break;}
        }
    }
    return array;
}

int [,] array = FillArray(3, 5);
PrintArray(array);
System.Console.WriteLine("Отсортированный массив :");
int [,] answer = BubbleSortLine(array);
PrintArray(answer);