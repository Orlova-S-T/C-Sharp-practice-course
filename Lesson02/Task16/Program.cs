bool SquareCheck(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}


Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (SquareCheck(firstNumber, secondNumber)) Console.WriteLine($"{firstNumber}, {secondNumber} -> одно число является квадратом другого");
else Console.WriteLine($"{firstNumber}, {secondNumber} -> ни одно из этих двух чисел не является квадратом другого");

