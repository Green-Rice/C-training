// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int DaysOfWeek = Prompt("Введите дни недели :");

if (DaysOfWeek < 1 || DaysOfWeek > 7)
{
    System.Console.WriteLine("Это не дни недели!");
    return;
}
if (DaysOfWeek == 6 || DaysOfWeek == 7)
{
    System.Console.WriteLine("Это выходной день недели!");
}
else
{
    System.Console.WriteLine("Это будний день недели!");
}

