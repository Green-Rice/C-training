//2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int number = new Random().Next(10, 100);
Console.Write(number);
int number1 = number % 10;
int number2 = number / 10;
if (number1 > number2)
{
    Console.Write(number1);
}
else
{
    Console.Write(number2);
}
