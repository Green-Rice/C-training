// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void ShowNaturalRow(int number)     //Функция с рекурсией
{
    if(number <=0)      //Условия выхода из функции
    {
        return;
    }
    ShowNaturalRow(number -1);      //Функция вызывает себя
    Console.WriteLine(number);
}
int number = Prompt("Введите число N :");
ShowNaturalRow(number);