// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
        array[i] = new Random().Next(100, 1000);
        i++;
    }
    return array;
}

int FindingEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;

}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length)
        {
            System.Console.Write($"{array[i]} ");
        }
    }
}

int size = Prompt("Введите размер массива ");
int[] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine(" >");
System.Console.WriteLine($"{FindingEvenNumber(array)}");