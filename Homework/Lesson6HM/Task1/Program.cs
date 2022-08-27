// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


int[] InputArray(int num)
{
    int[] array = new int[num];
    int i = 0;
    while (i < num)
    {
        Console.Write("Введите число ");
        array[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}


int CountingPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

//____________________________________________________________


int[] newArray = InputArray(Prompt("Введите размер массива"));
PrintArray(newArray);
System.Console.WriteLine($"Колличество чисел больше 0; {CountingPositiveNumbers(newArray)}");
