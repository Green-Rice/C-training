/*
Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
/*
int Prompt(string message)
{
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}

void SetN(int num)
{
 int i=1;
    while(i<=num)

    {

        System.Console.Write(i*i+" ");
        i++;

    }


}


SetN(Prompt("Введите число : "));
*/

int[] arrayFill(int size)
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
        System.Console.Write(array[i] + "\t");
    }

}

int Ma
d(result)} ");
