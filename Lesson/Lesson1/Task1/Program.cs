//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
int Prompt(string message)
{
System.Console.Write(message);              // Вывести сообщение
string readValue = Console.ReadLine();      // Считавает с консоли строку
int result = int.Parse(readValue);          // Преобрадует строку в целое число
return result;                              // Возвращает результат
}
int value1 = Prompt("Введите первое число >");
int value2 = Prompt("Введите второе число >");
int value3 = value2 * value2;
if (value1 == value3)
{
System.Console.WriteLine("Да");
}
else
{
System.Console.WriteLine("Нет");
}