Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int square = secondNumber * secondNumber;

if (square == firstNumber)
{
    Console.Write("Второе число является квадратом первого");
}

else
{
    Console.Write("Второе число не является квадратом первого");
}

