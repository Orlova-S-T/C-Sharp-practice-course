// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int UserInput(string text1, string text2) // Ввод пользователем числа int, запрос в 2 строки. 
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


bool NaturalSetCheck(int num) // Проверка числа на натуральность.
{
    return num > 0;
}


// // Рекурсивный метод вывода на печать натуральных чисел от заданного значения N до 1 (через пробел).
// void PrintFromNumToOne(int num)
// {
//     if (num == 0) return;
//     Console.Write($"{num} ");
//     PrintFromNumToOne(num - 1);
// }


// Рекурсивный метод вывода на печать натуральных чисел от заданного значения N до 1 (через запятую).
void PrintNaturalNumbersFromNumToOne(int num)
{
    if (num != 1)
    {
        Console.Write($"{num}, ");
        PrintNaturalNumbersFromNumToOne(num - 1);
    }
    else
    {
        Console.WriteLine(1); // Для вывода последнего числа без запятой.
        return;
    }
}




int number = UserInput("Введите любое натуральное число", "N = ");

while (!NaturalSetCheck(number))
{
    Console.WriteLine($"Ошибка ввода. Число {number} не является натуральным");
    number = UserInput("Необходимо ввести целое число больше ноля. Повторите попытку", "N = ");
}

PrintNaturalNumbersFromNumToOne(number);

