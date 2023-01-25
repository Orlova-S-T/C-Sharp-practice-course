// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5  7    -2   -0,2
// 1   -3,3   8   -9,9
// 8    7,8  -7,1  9


double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max, int round) // Создание двумерного массива и заполнение его вещественными псевдослучайными числами.
{
    double[,] matrix = new double[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rendom = min + rnd.NextDouble() * (max - min);
            double roundRendom = Math.Round(rendom, round, MidpointRounding.ToZero);
            // Console.WriteLine($"{rendom} -> {roundRendom}");
            matrix[i, j] = roundRendom;
        }
    }
    return matrix;
}


void PrintMatrixDouble(double[,] matrix) // Вывод двумерного массива на печать (через пробел, каждая строчка обрамлена прямым слэшем |).
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],6} "); // 6 - количество знаков, отводимых на вывод каждого числа
            else Console.Write($"{matrix[i, j],6} ");
        }
        Console.WriteLine(" |");
    }
}


Console.WriteLine();

double[,] array2D = CreateMatrixRndDouble(rows: 3, columns: 4, min: -99, max: 99, round: 1);
PrintMatrixDouble(array2D);

Console.WriteLine();

