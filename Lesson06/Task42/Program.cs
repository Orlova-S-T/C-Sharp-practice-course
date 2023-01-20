// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Первое решение на семинаре - Павел:
int ParseIn2(int num) // Метод перевода десятичного числа в двоичное.
{
    if (num == 0) return 0; // Плохо понимаю, почему в конце прогона функция не возвращает этот 0 ВСЕГДА.
    int result = num % 2;
    num /= 2;
    result = result + ParseIn2(num) * 10; // result += ParseIn2(num) * 10; - если сокращённо
    // Умножение рекурсии на 10 я пока "не догоняю".
    return result;
}


Console.WriteLine("Введите число:");
var num = Console.ReadLine();
Console.WriteLine(ParseIn2(Convert.ToInt32(num)));

//Console.WriteLine(ParseIn2(Convert.ToInt32(Console.ReadLine()))); - если всё в одну строку




// Второе решение на семинаре - Павел Нагорнов (демонстрировал Кирилл):
int NumberInput(string text) // Method fot Number input
{
    Console.WriteLine(text);
    int numberinput = Convert.ToInt32(Console.ReadLine());
    return numberinput;
}


int DecToBin(int num) // Метод перевода десятичного числа в двоичное (с семинара, Павел Нагорнов и Кирилл).
// Не работает с отрицательными числами.
{
    if (num == 0) return 0;
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        // Я не догадалась перевернуть строку, просто прибавляя результат в конце, а не ставя его в начало!
        num /= 2;
    }
    int bin = Convert.ToInt32(result);
    return bin;
}


int number = NumberInput("Please, input your number");
Console.WriteLine(DecToBin(number));

