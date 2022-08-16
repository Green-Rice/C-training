// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int number = Prompt("Введите число > ");
int count=0;
while(number>0)
{
    number=number/10;
    count++;
}
System.Console.WriteLine($"Колличество цифр в числе {count}");
