// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}


void CalculationIntersectionPoints(double x1, double x2, double y1, double y2)
{
    if (x1 == x2)
    {
        if (x1 == x2 && y1 == y2)
        {
            System.Console.WriteLine("Линии совпадают!");
        }
        else
        {
            System.Console.WriteLine("Пересечения линий нет!");
        }
    }
    else
    {
        double a = (-x2 + x1) / (-y1 + y2);
        double b = y2 * a + x2;
        Console.WriteLine($"Точка пересечения: ({a}; {b})");
    }
}

double x1 = Prompt("Введите кординату х1 :");
double y1 = Prompt("Введите кординату y1 :");
double x2 = Prompt("Введите кординату x2 :");
double y2 = Prompt("Введите кординату y2 :");
CalculationIntersectionPoints(x1, x2, y1, y2);