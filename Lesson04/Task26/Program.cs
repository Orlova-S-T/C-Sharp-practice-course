// Задача 26: Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DigitCount(int num)
{
    int count = 0;
    //while (num > 0) Не работает для отрицательных чисел и 0.
    while (num != 0) // Не работает только для 0 - для него выдаёт 0 цифр.
    {
        num = num / 10;
        count++;
    }
    return count;
}


Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

int result = DigitCount(number);
Console.WriteLine($"Количество цифр в числе {number} равно {result}");

