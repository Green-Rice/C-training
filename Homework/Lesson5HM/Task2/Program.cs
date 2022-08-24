// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] FillArray(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(-100, 100);
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length)
        {
            System.Console.Write($"{array[i]},");
        }
    }
}

int SumOfElements(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result = result + array[i];
    }
    return result;
}

int size = Prompt("Введите размер массива :");
int[] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine($"Сумма нечетных элементов = {SumOfElements(array)}");