// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int Promt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int num1 = Promt("Введите число : ");

for (int i = 2; i <= num1; i=i+2)
    {
        System.Console.Write(i+" ");
    }