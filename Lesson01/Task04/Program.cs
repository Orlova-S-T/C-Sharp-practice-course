﻿Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber && firstNumber == thirdNumber)
{
    Console.WriteLine("Среди введённых чисел нет максимального - эти числа равны");
}

else
{
    int max = firstNumber;
    if (secondNumber > max) max = secondNumber; //Нам на лекции такую конструкцию показали (без фигурных скобок). Работает.
    if (thirdNumber > max) max = thirdNumber;

    Console.Write("max = ");
    Console.WriteLine(max);
}