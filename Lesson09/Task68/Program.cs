// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


int UserInput(string text1, string text2) // Ввод пользователем числа int, запрос в 2 строки. 
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


bool ExclusionOfNegativeNumbers(int num) // Проверка, что число неотрицательное.
{
    return num >= 0;
}


// Рекурсивный метод вычисления функции Аккермана. 
int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}




int numM = UserInput("Введите первое целое число", "M = ");

while (!ExclusionOfNegativeNumbers(numM))
{
    Console.WriteLine($"Ошибка ввода. Число {numM} меньше нуля");
    numM = UserInput("Необходимо ввести целое число больше либо равное нулю. Повторите попытку", "M = ");
}


int numN = UserInput("Введите второе целое число", "N = ");

while (!ExclusionOfNegativeNumbers(numN))
{
    Console.WriteLine($"Ошибка ввода. Число {numN} меньше нуля");
    numN = UserInput("Необходимо ввести целое число больше либо равное нулю. Повторите попытку", "N = ");
}


int function = AckermannFunction(numM, numN);
Console.WriteLine($"Для M = {numM} и N = {numN} функция Аккермана A({numM},{numN}) равна {function}");

