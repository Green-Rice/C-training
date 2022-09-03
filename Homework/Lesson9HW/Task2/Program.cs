// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int ShowSumNaturalNumber(int m, int n)     //Функция показывает сумму натуральных чисел
{
    if (m > n)      //Условия выхода из функции
    {
        return 0;
    }
    return ShowSumNaturalNumber(m + 1, n) + m;      //Функция вызывает себя
}

int m = Prompt("Введите число М :");
int n = Prompt("Введите число N :");
if (m > n)
{
    System.Console.WriteLine("Число М не должно быть больше числа N");
}
else
{
    System.Console.WriteLine($"M = {m}\t N {n}\t Сумма чисел = {ShowSumNaturalNumber(m, n)}");
}