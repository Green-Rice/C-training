//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int num = new Random().Next(99, 999);
System.Console.WriteLine(num);
int value = ((num / 100)*10 + num % 10);
System.Console.WriteLine(value);