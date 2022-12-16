Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"Введённое число {number} является чётным");
}

else
{
    Console.WriteLine($"Введённое число {number} не является чётным");
}
