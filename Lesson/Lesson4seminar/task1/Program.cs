// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumSequence(int number){
    int answer = 0;
    for(int i=0; i<= number; i++)
    {
        answer=answer+i;
    }
    return answer;
}
int number=Prompt("Введите число >");
System.Console.WriteLine($"Сумма чисел от 1 до {number} состовляет {SumSequence(number)}");
