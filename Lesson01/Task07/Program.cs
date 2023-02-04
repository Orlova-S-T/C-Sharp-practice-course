// Задача 7: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int module = Math.Abs(number);
if (module > 99 && module < 1000)
{
    int lastDigit = module % 10;
    Console.WriteLine(lastDigit);
}
else
Console.WriteLine("Неправильно набран номер");

