// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

long number = Prompt("Введите число >");
long mult = 1;
for(long i = 1; i <= number; i++)
{
    mult = mult * i;
}

System.Console.WriteLine($"Произведение чисел {mult}");