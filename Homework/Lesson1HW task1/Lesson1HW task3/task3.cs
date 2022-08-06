//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int num = Prompt("Введите число для проверки >");
if (num % 2 == 0)
{
    System.Console.Write("Число четное");
}
else
{
    System.Console.Write("Число  нечетное");
}