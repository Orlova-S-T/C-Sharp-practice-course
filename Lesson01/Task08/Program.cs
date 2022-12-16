Console.Write("Введите любое натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.Write($"Ошибка ввода. Число {number} не является действительным. Необходимо ввести целое число больше ноля. Снова запустите программу и повторите попытку.");
}

else if (number == 1)
{
    Console.Write("Нет действительных чётных чисел меньше 2. Снова запустите программу и введите действительное число от 2 и более.");
}

else if (number == 2)
{
    Console.Write(number);
}

else
{
    int count = 2;
    while (count < number - 1)
    {
        Console.Write($"{count}, ");
        count += 2;
    }
    if (number == count) //Условие добавлено чтобы выводить последнее число без запятой.
    {
        Console.Write(number); //Последнее выводимое число, если исходное число чётное. 
    }
    else
    {
        Console.Write(number - 1); // Последнее выводимое число, если исходное число нечётное.
    }
}

