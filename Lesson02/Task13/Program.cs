Console.Write("Введите целое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = Math.Abs(userNumber); //В условии задачи не сказано, что трёхзначное число должно быть положительным.

if (number < 100) //Если введённое число является одно- или двухзначным.
{
    Console.WriteLine($"У введённого числа {userNumber} нет третьей цифры.");
}

else
{
    while (number > 999)
        {
            number = number / 10;
        }
    number = number % 10;
    Console.WriteLine($"{userNumber} -> {number}");
}
//Не стала добавлять в решение никакие функции, без них изящнее.

