// Задача 14: Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да


bool Div7And23Check(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.Write("Введите целое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (Div7And23Check(userNumber1)) Console.WriteLine($"{userNumber1} кратно одновременно 7 и 23");
else Console.WriteLine($"{userNumber1} не кратно одновременно 7 и 23");

