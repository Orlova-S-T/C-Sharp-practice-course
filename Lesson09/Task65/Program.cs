// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


int UserInput(string text1, string text2) // Ввод пользователем числа int, запрос в 2 строки. 
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


void PrintNaturalNumbersFromFirstToSecond(int m, int n) // Рекурсивный метод вывода на печать целых чисел от M до N (задаются в инструкции).
{
    if (m == n) // Условие выхода из рекурсии.
    {
        Console.Write($"{m} "); // Без этой строки мы потеряем первое из выводимых чисел - m.
        return;
    }

    if (m < n)
    {
        PrintNaturalNumbersFromFirstToSecond(m, n - 1);
    }
    else
    {
        PrintNaturalNumbersFromFirstToSecond(m, n + 1);
    }

    Console.Write($"{n} ");
}


int numM = UserInput("Введите любое натуральное число", "M = ");
int numN = UserInput("Введите любое натуральное число", "N = ");

PrintNaturalNumbersFromFirstToSecond(numM, numN);

