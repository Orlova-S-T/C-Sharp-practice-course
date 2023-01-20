// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int UserInput(string text) // Ввод пользователем числа int.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


int ConvertDecimalNumberToBinary(int decNum) // Метод перевода десятичного числа в двоичное.
// Не работает с отрицательными числами.
{
    string GetRemaindersOfDivisionByTwo(int num, string txt) // Последовательное нахождение остатков деления десятичного числа на 2 (с рекурсией).
    {
        txt = txt + (num % 2);
        if (num / 2 != 0) txt = GetRemaindersOfDivisionByTwo(num / 2, txt);
        return txt;
    }


    int RevNum(int num) // "Переворот" числа.
    {
        int revNum = 0;
        while (num > 0)
        {
            revNum = revNum * 10 + num % 10;
            num = num / 10;
        }
        return revNum;
    }


    string emptyStr = "";
    string revStr = GetRemaindersOfDivisionByTwo(decNum, emptyStr);
    int length = revStr.Length;
    // Console.WriteLine(revStr);
    // Console.WriteLine(length);

    int overturn = Convert.ToInt32(revStr); // Сначала не справилась с незначащим нулём в начале перевёрнутого числа. При конвертации он теряется.
    int binNum = RevNum(overturn);

    if (binNum < Math.Pow(10, length-1)) binNum = binNum * 10; // Эту проблему удалось решить через сравнение с длиной строки.
    return binNum;
}


int decimalNumber = UserInput("Введите любое натуральное число: ");
int binaryNumber = ConvertDecimalNumberToBinary(decimalNumber);
Console.WriteLine($"Десятичное число {decimalNumber} в двоичной системе счисления равно {binaryNumber}");

