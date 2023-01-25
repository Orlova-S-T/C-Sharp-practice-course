// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRndIntAcrossRows(int rows, int columns, int min, int max) // Создание двумерного массива и заполнение его целыми псевдослучайными числами.
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix2(int[,] matrix) // Вывод двумерного массива на печать (через пробел, каждая строчка обрамлена прямым слэшем |).
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} "); // 5 - количество знаков, отводимых на вывод каждого числа
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("  |");
    }
}


double[] GetMatrixColumnsArithmeticMeans(int[,] matrix, int round) // Создание одномерного массива с элементами, являющимися средним арифметическим по столбцам двумерного массива (в виде вещественных чисел с округлением до нужного знака round после запятой).
{
    int length = matrix.GetLength(1);
    int height = matrix.GetLength(0);
    double[] collection = new double[length]; // Изначально новый массив collection заполнен нолями.
    double temp = 0;

    for (int j = 0; j < length; j++)
    {
        for (int i = 0; i < height; i++)
        {
            if (i < height - 1)
            {
                collection[j] = collection[j] + matrix[i, j];
            }
            else
            {
                temp = (collection[j] + matrix[i, j]) / height;
                collection[j] = Math.Round(temp, round, MidpointRounding.ToZero);
            }
        }
    }

    return collection;
}


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




Console.WriteLine();
int[,] array2D = CreateMatrixRndIntAcrossRows(3, 4, -99, 99);
PrintMatrix2(array2D);
Console.WriteLine();


int decimalPlace = 1; // Число знаков после запятой у среднего арифметическо элементов столбцов.
double[] array = GetMatrixColumnsArithmeticMeans(array2D, decimalPlace);

Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(array);
Console.WriteLine();

