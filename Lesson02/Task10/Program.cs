// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


bool CheckThreeDigit(int num) //Метод проверки целого числа на трёхзначность.
{
    return Math.Abs(num) > 99 && Math.Abs(num) < 1000; //В условии задачи не сказано, что трёхзначное число должно быть положительным.
}

int MidFromTree(int fig) //Метод, вычисляющий среднюю цифру целого трёхзначного числа.
{
    int result = fig % 100 / 10;
    return Math.Abs(result);
}


Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (!CheckThreeDigit(number))
{
    Console.WriteLine($"Введённое вами число {number} не является трёхзначным. Перезапустите программу и повторите попытку.");
}

else
{
    int figure = MidFromTree(number);
    Console.WriteLine($"{number} -> {figure}");
}

