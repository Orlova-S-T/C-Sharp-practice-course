// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// Примечания:
// Случайные вещественные числа (от 0 до 1) генерируются с помощью метода .NextDouble().
// Округлять их нужно отдельным действием.


double[] CreateArrayRndDouble(int size, int min, int max, int round) // Создание массива и заполение его случайными вещественными числами (с округлением до нужного знака round после запятой).
{
    double[] collection = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        double rendom = min + rnd.NextDouble() * (max - min);
        double roundRendom = Math.Round(rendom, round, MidpointRounding.ToZero);
        // Console.WriteLine($"{rendom} -> {roundRendom}");
        collection[i] = roundRendom;
    }
    return collection;
}
// Как с округлением до нуля (ToZero), так и с округлением до чётного числа (ToEven) последний ноль после запятой не выводится на печать.


void PrintArrayDouble(double[] collection) // Вывод массива из вещественных чисел на печать с квадратными скобками.
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) Console.Write(collection[i] + "; ");
        // У меня русский язык и числа выводятся с запятой, а не с точкой.
        // Поэтому отделила элементы массива на печати точкой с запятой.
        else Console.Write(collection[i]);
    }
    Console.WriteLine("]");
}


double MaxElem(double[] collection) // Поиск максимального элемента в массиве из вещественных чисел.
{
    double max = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
        if (collection[i] > max) max = collection[i];
    }
    return max;
}


double MinElem(double[] collection) // Поиск минимального элемента в массиве из вещественных чисел.
{
    double min = collection[0];
    for (int i = 1; i < collection.Length; i++)
    {
        if (collection[i] < min) min = collection[i];
    }
    return min;
}



int number = 5; // Количество элементов в массиве.
int minimum = -99; // Диапазон для элементов массива: минимальное число.
int maximum = 99; // Диапазон для элементов массива: максимальное число.
int decimalPlace = 1; // Число знаков после запяой у элементов массива.


double[] array = CreateArrayRndDouble(number, minimum, maximum, decimalPlace);
PrintArrayDouble(array);

double maxElem = MaxElem(array);
double minElem = MinElem(array);

double difference = maxElem - minElem;
Console.WriteLine($"Разность между максимальным ({maxElem}) и минимальным ({minElem}) элементами массива равна {difference}");

// double roundDifference = Math.Round(difference, 1, MidpointRounding.ToZero);
// Console.WriteLine($"Разность между максимальным ({maxElem}) и минимальным ({minElem}) элементами массива равна {roundDifference}");

