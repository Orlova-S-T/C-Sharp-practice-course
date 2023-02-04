// Задача 9: Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8


// int number = new Random().Next(10, 100);
// Console.WriteLine($"Случайное число из диапазона [10, 99] равно {number}");

// int firstDigit = number / 10;
// int secondDigit = number - firstDigit * 10; //Или просто int secondDigit = number % 10.

// if (firstDigit == secondDigit) Console.WriteLine($"Обе цифры числа одинаковые и равны {firstDigit}");
// else if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} равна {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} равна {secondDigit}");

// Последние 2 строчки можно записать подругому:
// Console.Write($"Наибольшая цифра числа {number} равна ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);


//А теперь - решение с созданем метода:
int MaxDigit(int num) //Параметр num в нашем случае будет равен локальной переменной number.
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

int number = new Random().Next(10, 100);
Console.Write($"Случайное число из диапазона [10, 99] равно {number}, наибольшая цифра числа равна ");
int maxDigit = MaxDigit(number);
Console.WriteLine(maxDigit);

// Метод можно чутка упростить:
// int MaxDigit(int num)
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     return firstDigit > secondDigit ? firstDigit : secondDigit;
// }

