// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int ReverseNumber(int number)
{
    int rev = 0;
    while (number > 0)
    {
        int temp = number % 10;
        number = number / 10;
        rev = rev * 10 + temp;
    }
    return rev;
}

bool CheckPolindrome(int value, int value2)
{
    if (value == value2)
    {
        return true;
    }
    return false;
}


int number = Prompt("Введите пятизначное число :");
int number2 = ReverseNumber(number);
bool isPalindrome =CheckPolindrome(number,number2 );
if(isPalindrome)
{
    Console.WriteLine($"{number} является числом палиндромом.");
}
else
{
    Console.WriteLine($"{number} не является числом палиндромом.");
}
