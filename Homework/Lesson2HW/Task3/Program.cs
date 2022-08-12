//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

int Separate3number(int value)
{
    while (value > 1000)
    {
        value = value / 10;
    }
    int result = value % 10;
    return result;
}

int value = Prompt("Введите число: ");

if (value > 99)
{
    int result = Separate3number(value);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры в числе нет!");
}