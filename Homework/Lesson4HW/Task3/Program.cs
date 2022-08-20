// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран. И ищет второй максимум (элемент меньше максимального, но больше всех остальных)
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19
*/


int[] FillArray(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(0, 101);
        i++;
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
}

void TwoMaxArray(int[] array)
{
    int MaxNumber = array[0];
    int ToMaxNumber = array[1];
    int swap = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > MaxNumber)
        {
            swap = MaxNumber;
            MaxNumber = array[i];
            ToMaxNumber = swap;
        }
        else if (array[i] > ToMaxNumber)
        {
            ToMaxNumber = array[i];
        }
    }
    System.Console.WriteLine($"  Max={MaxNumber}");
    System.Console.WriteLine($"NextMax={ToMaxNumber}");
}
int[] result = FillArray(8);
printArray(result);
TwoMaxArray(result);

