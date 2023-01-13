//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B:
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16 


double UserInputDouble(string text1, string text2) // Ввод пользователем числа A в формате double (запрос в 2 строки).
{
    Console.WriteLine(text1);
    Console.Write(text2);
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}

int UserInputInt(string text1, string text2) // Ввод пользователем числа B в формате int (запрос в 2 строки). 
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

bool NaturalSetCheck(int num) // Проверка числа на натуральность.
{
    return num > 0;
}

double NumberDegree(double numA, int numB) // Возведение числа A в степень B (B принадлежит множеству натуральных чисел N).
{
    double degree = 1;
    for (int i = 1; i <= numB; i++)
    {
        degree = degree * numA;
    }
    return degree;
}


double numberA = UserInputDouble("Введите число, являющееся основанием степени:", "A = ");
int numberB = UserInputInt("Введите натуральное число, являющееся показателем степени:", "B = ");
if (!NaturalSetCheck(numberB))
{
    Console.Write($"Ошибка ввода. Введённое вами число B = {numberB} не является натуральным. Необходимо ввести целое число больше ноля. Снова запустите программу и повторите попытку.");
}
else
{
    double result = NumberDegree(numberA, numberB);
    Console.WriteLine($"Число A = {numberA} в степени B = {numberB} равно {result}");
}

