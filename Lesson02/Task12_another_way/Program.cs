// Задача 12: Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


bool DivCheck(int num1, int num2)
{
    return num1 % num2 == 0;
}

Console.Write("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (DivCheck(userNumber1, userNumber2)) //Такой вывод означает "если в функции получилось true".
{
    Console.WriteLine($"{userNumber1}, {userNumber2} -> кратно");
}
else
{
    Console.WriteLine($"{userNumber1}, {userNumber2} -> не кратно, остаток " + (userNumber1 % userNumber2));
}

