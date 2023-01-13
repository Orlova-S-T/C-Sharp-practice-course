// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int UserInput(string text) // Ввод пользователем данных типа int.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


int FindModule(int num) // Модуль числа.
{
    int module = Math.Abs(num);
    return module;
}


int DigitsSum(int num) // Подсчёт суммы цифр в числе (только для положительных чисел и нуля).
{
    int sum = num % 10;
    while (num > 0)
    {
        num = num / 10;
        sum = sum + num % 10;
    }
    return sum;
}


int userNumber = UserInput("Введите любое целое число: ");
int number = userNumber;
if (userNumber < 0) number = FindModule(userNumber);
int result = DigitsSum(number);
Console.WriteLine($"Сумма цифр в числе {userNumber} равна {result}");

