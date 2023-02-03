// Задача 66: Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30


int UserInput(string text1, string text2) // Ввод пользователем числа int, запрос в 2 строки. 
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


// Рекурсивный метод получения суммы целых чисел от M до N (включительно) через Math.Sign.
int GetSumFromFirstToSecondNumber(int m, int n)
{
    int sign = Math.Sign(n - m);
    if (m == n) return n;
    return m + GetSumFromFirstToSecondNumber(m + 1 * sign, n);
}




int numM = UserInput("Введите первое целое число", "M = ");
int numN = UserInput("Введите второе целое число", "N = ");

while (numM == numN) // Если пользователь ввёл два одинаковых числа.
{
    Console.WriteLine($"Ошибка ввода. Вы ввели два одинаковых числа ({numM} и {numN})");
    numN = UserInput("Повторите попытку и введите другое целое число N", "N = ");
}


int sum = GetSumFromFirstToSecondNumber(numM, numN);
Console.WriteLine($"Сумма целых чисел от {numM} до {numN} (включительно) равна {sum}");

