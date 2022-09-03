// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int numbers)
{
    int sum = 0;
    if (numbers == 0)
    {
        return sum;
    }
    sum = sum + numbers % 10;
    return SumDigit(numbers / 10) + sum;
}

int numbers = Prompt("Введите число :");
int sum = SumDigit(numbers);
System.Console.WriteLine(sum);
