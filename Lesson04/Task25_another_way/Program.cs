// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16 
// Для целых показателей степени.

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

double NaturalDegree(double numA, int numB) // Возведение числа A в степень B (B принадлежит множеству натуральных чисел N).
{
    double degree = 1;
    for (int i = 1; i <= numB; i++)
    {
        degree = degree * numA;
    }
    return degree;
}

double IntegerDegree(double basisA, int indexB) // Возведение числа A в степень B (B принадлежит множеству целых чисел Z).
{
    double value = 1;
    if (indexB > 0)
    {
        value = NaturalDegree(basisA, indexB);
    }
    if (indexB < 0)
    {
        int module = Math.Abs(indexB);
        value = 1 / NaturalDegree(basisA, module);
    }
    return value;
}


double numberA = UserInputDouble("Введите число, являющееся основанием степени:", "A = ");
int numberB = UserInputInt("Введите натуральное число, являющееся показателем степени:", "B = ");
double result = IntegerDegree(numberA, numberB);
Console.WriteLine($"Число A = {numberA} в степени B = {numberB} равно {result}");

