// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int Prompt(string message)
{
    System.Console.Write(message);              // Вывести сообщение
    string readValue = Console.ReadLine();      // Считавает с консоли строку
    int result = int.Parse(readValue);          // Преобрадует строку в целое число
    return result;                              // Возвращает результат
}
int a = Prompt("Введите первое число >");
int b = Prompt("Введите второе число >");
int c = Prompt("Введите третье число >");
int big = a;
if ((a > b) && (a > c)) { big = a; }
else if ((b > a) && (b > c)) { big = b; }
else if ((c > a) && (c > b)) { big = c; }
System.Console.WriteLine($"max = {big}");