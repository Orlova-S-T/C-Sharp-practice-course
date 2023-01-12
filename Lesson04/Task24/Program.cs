// Задача 24: Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А:
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num) // В методе при выполнении этой программы аргументу num
                        // будет присвоено значение переменной number.
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine()); // Берёт для преобразования только строку.
//int number = Convert.ToInt32(Console.ReadLine()); Принимает любой тип данных, который
// можно преобразовать в число.

int result = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {result}");

