// Напишите программу, которая будет принимать на вход пять чисел
// и выводить сумму и среднее арифметическое этих чисел.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int[] inputarray(int Length)
{
    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i} элемент");
    }
    return array;
}
int Summ(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        summ = summ + array[i];
    }
    return summ;
}
int[] array = inputarray(3);
int summ = Summ(array);
double average = summ / ((double)array.Length);
System.Console.WriteLine($"Сумма равна {summ}, среднее равно {average}");
