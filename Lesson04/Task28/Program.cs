// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт
// произведение чисел от 1 до N:
// 4 -> 24
// 5 -> 120

int CompNumbers(int num)
{
    int composition = 1;
    for (int i = 1; i <= num; i++)
    {
        composition = composition * i;
    }
    return composition;
}

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int result = CompNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {result}");

