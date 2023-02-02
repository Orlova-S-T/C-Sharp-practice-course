// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


void PrintNaturalNumbers(int m, int n) // Рекурсивный вывод на печать целых чисел от M до N через Math.Sign (Кирилл).
{
    int sign = Math.Sign((n - m));
    Console.Write($"{m} ");
    if (m == n) return;
    PrintNaturalNumbers(m + 1 * sign, n);
}


Console.WriteLine("Please, enter number M:");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please, enter number N:");
int numN = Convert.ToInt32(Console.ReadLine());

while (numM == numN) // Если пользователь ввёл два одинаковых числа.
{
    Console.WriteLine("Your numbers are equal! Please, reenter number N:");
    numN = Convert.ToInt32(Console.ReadLine());
}

PrintNaturalNumbers(numM, numN);

