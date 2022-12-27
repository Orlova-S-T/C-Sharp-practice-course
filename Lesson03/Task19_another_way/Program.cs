int UserInput(string text) //Ввод пользователем числа.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
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


int userNumber = UserInput("Введите пятизначное целое число: ");
int number = Math.Abs(userNumber);
if (number > 9999 && number < 100000) //Конкретно в нашей задаче - число должно быть пятизначным.
{
    int revNum = RevNum(number);
    Console.WriteLine($"{number} -> {revNum}");
    if (number == revNum) Console.WriteLine($"Число {userNumber} является палиндромом");
    else Console.WriteLine($"Число {userNumber} не является палиндромом");
}
else
{
    Console.WriteLine($"Ошибка ввода. Введённое вами число не является пятизначным. Снова запустите программу и повторите попытку");
}

