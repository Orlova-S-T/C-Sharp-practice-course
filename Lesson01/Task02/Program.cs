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

