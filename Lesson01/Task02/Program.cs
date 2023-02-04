// Задача 2: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine($"{firstNumber} больше чем {secondNumber}");
}
else if (firstNumber == secondNumber)
{
    Console.WriteLine("Среди введённых чисел нет большего и меньшего - эти числа равны");
}
else
{
    Console.WriteLine($"{secondNumber} больше чем {firstNumber}");
}

