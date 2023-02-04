// Задача 1: Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.

// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int square = secondNumber * secondNumber;

if (square == firstNumber)
{
    Console.Write("Второе число является квадратом первого");
}

else
{
    Console.Write("Второе число не является квадратом первого");
}

