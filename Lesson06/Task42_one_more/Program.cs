// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Моё решение с "нелегальными" встроенными методами:
int UserInput(string text) // Ввод пользователем числа int.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


string GetRemaindersOfDivisionByTwo(int num, string txt) // Последовательное нахождение остатков деления десятичного числа на 2 (с рекурсией).
{
    txt = txt + (num % 2);
    if (num / 2 != 0) txt = GetRemaindersOfDivisionByTwo(num / 2, txt);
    return txt;
}


int decimalNumber = UserInput("Введите любое натуральное число: ");

string revNum = GetRemaindersOfDivisionByTwo(decimalNumber, "");
Console.WriteLine(revNum);

char [] array = revNum.ToCharArray();
Array.Reverse(array);
string binNum = new String(array);
int binaryNumber = Convert.ToInt32(binNum);

Console.WriteLine($"Десятичное число {decimalNumber} в двоичной системе счисления равно {binaryNumber}");

