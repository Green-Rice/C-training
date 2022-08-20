// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/



int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int SumNumber(int number)
{
    int result = 0;
    while (number != 0)
    {
        result = result + number % 10;
        number= number/10;
    }
    return result;
}
int number = Prompt("Введите число :");
System.Console.WriteLine($"{number} -> {SumNumber(number)}");
System.Console.WriteLine();
