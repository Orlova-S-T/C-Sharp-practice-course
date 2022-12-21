int DelMiddleDigit(int num) //Параметр num в нашем случае будет равен локальной переменной number.
{
    int firstDigit = num / 100; //Первая цифра трёхзначного числа.
    int thirdDigit = num % 10;  //Последняя цифра трёхзначного числа.
    int result = firstDigit * 10 + thirdDigit;
    return result;
}

int number = new Random().Next(100, 1000);
Console.Write($"Случайное число из диапазона [100, 999] равно {number} -> искомое число равно ");
int digit = DelMiddleDigit(number); //Искомое двузначное число.
Console.WriteLine(digit);

