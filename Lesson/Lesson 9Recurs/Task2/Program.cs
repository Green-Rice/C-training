﻿// Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void ShowNaturalRow(int min, int max)
{
    if (min > max)
    {
        return;
    }
    ShowNaturalRow(min, max -1);
    System.Console.Write($"{max}\t");

}

int min = Prompt("Введите число Min :");
int max = Prompt("Введите число Max :");
ShowNaturalRow(min, max);