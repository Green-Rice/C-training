﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29



int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AckermannFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}
int m = Prompt("Введите число М ");
int n = Prompt("Введите число N ");
System.Console.WriteLine(AckermannFunction(m,n));