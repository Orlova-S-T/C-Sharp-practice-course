int UserInput(string text) //Ввод пользователем числа.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int CounterDigits(int num1) // Подсчёт количества цифр в числе.
{
    int order = num1 / 10;
    if (order == 0) return 1;
    int count = 1;
    while (order > 0)
    {
        order = order / 10;
        count++;
    }
    return count;
}

int ReversNumber(int num2, int lenght) // "Переворот" числа.
{
    int lastDigit = num2 % 10;
    if (lastDigit == num2) return lastDigit;
    int score = 1;
    int multiplier = 1;
    while (score < lenght)
    {
        multiplier = multiplier * 10;
        score++;
    }
    int sum = 0;
    int digit = 0;
    int position = 1;
    int divider = 1;
    while (position <= lenght)
    {
        digit = num2 % (divider * 10) / divider;
        sum = sum + digit * multiplier;
        divider = divider * 10;
        multiplier = multiplier / 10;
        position++;
    }
    return sum;
}


int userNumber = UserInput("Введите пятизначное целое число: ");
int number = Math.Abs(userNumber);
int userCount = CounterDigits(number);
if (userCount == 5) //Конкретно в нашей задаче - число должно быть пятизначным.
{
    int reversNumber = ReversNumber(number, userCount);
    Console.WriteLine($"{number} -> {reversNumber}");
    if (number == reversNumber) Console.WriteLine($"Число {userNumber} является палиндромом");
    else Console.WriteLine($"Число {userNumber} не является палиндромом");
}
else
{
    Console.WriteLine($"Ошибка ввода. Введённое вами число не является пятизначным. Снова запустите программу и повторите попытку");
}

