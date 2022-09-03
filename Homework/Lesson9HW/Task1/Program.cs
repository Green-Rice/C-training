// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowEvenNaturalNumber(int m, int n)     //Функция показывает натуральные четные числа
{
    if (m > n)      //Условия выхода из функции
    {
        return;
    }
    if(m %2 == 0)
    {
        System.Console.WriteLine($"{m}\t");
    }
    ShowEvenNaturalNumber(m +1, n);      //Функция вызывает себя
}

int m = Prompt("Введите число М ");
int n = Prompt("Введите число N ");
ShowEvenNaturalNumber(m, n);
