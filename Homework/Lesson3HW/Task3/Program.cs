// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void tableCubeNumbers(int num)
{
    for (int i = 1; i <= num; i++)
    {
        System.Console.Write(i * i * i + " ");
    }
}


int num = Prompt("Введите число :");
System.Console.WriteLine($"Таблица кубов от 1 до {num}:");
tableCubeNumbers(num);

