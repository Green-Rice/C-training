// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int MathematicalDegree(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int a = Prompt("Введите число А ");
int b = Prompt("Введите число B ");
int result = MathematicalDegree(a, b);
if (b < 0)
{
    System.Console.WriteLine("Ввели не корректное число");
}
else
{

    System.Console.Write($"Число {a} в натуральной степени {b} = {result} ");
}