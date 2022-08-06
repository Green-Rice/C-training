//Задача номер 1! Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньше!
int Prompt(string message)
{
    System.Console.Write(message);              // Вывести сообщение
    string readValue = Console.ReadLine();      // Считавает с консоли строку
    int result = int.Parse(readValue);          // Преобрадует строку в целое число
    return result;                              // Возвращает результат
}
int value1 = Prompt("Введите первое число >");
int value2 = Prompt("Введите второе число >");
if (value1 > value2)
{
    System.Console.WriteLine($"max = {value1} , min = { +value2}");
}
else
{
    System.Console.WriteLine($"max = {value2} , min = { +value1}");
}