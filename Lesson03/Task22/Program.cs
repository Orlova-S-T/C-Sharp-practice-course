// Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4


int UserInput(string text1, string text2)
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

bool NaturalSetCheck(int num)
{
    return num > 0;
}

void SquareN(int naturalNumber)
{
    double squareN = Math.Pow(naturalNumber, 2);
    Console.WriteLine($"{naturalNumber} -> {squareN}");
    // Здесь можно вывести результат по-другому:
    // Console.WriteLine($"{naturalNumber,5} {squareN,5}");
    // 5 - количество символов, задействованных для вывода переменной,
    // тогда получим ровные столбцы для числа знаков <= 5.
}


int number = UserInput("Введите любое натуральное число", "N = ");

if (NaturalSetCheck(number))
{
    int count = 1;
    while (count <= number)
    {
        SquareN(count);
        count++;
    }
}

else Console.Write($"Ошибка ввода. Число {number} не является действительным. Необходимо ввести целое число больше ноля. Снова запустите программу и повторите попытку.");


// Для проверки числа на натуральность можно было использовать цикл:
// int number = UserInput("Введите любое натуральное число", "N = ");
// while (number < 1)
// {
//     number = UserInput("Введите любое натуральное число", "N = ");
// }
// Тогда пользователя зацикли ли бы на ввод правильного числа.
// Дальше пишем программу для натурального числа.

