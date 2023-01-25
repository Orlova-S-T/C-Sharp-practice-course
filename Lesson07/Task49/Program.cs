// Задача 49: Задайте двумерный массив.
// Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// Новый массив будет выглядеть вот так:
// 1  4  49 2
// 5  9  2  3
// 64 4  4  4


int[,] CreateMatrixRndIntAcrossRows(int rows, int columns, int min, int max) // Создание двумерного массива и заполнение его псевдослучайными числами.
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


void PrintMatrix(int[,] matrix) // Вывод двумерного массива на печать (через пробел, каждая строчка обрамлена прямым слэшем |).
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


void ChangeMatrixElemWithEvenIndexesForSquare(int[,] matrix) // Замена элементов с чётными индексами i и j на их квадраты.
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}


int[,] array2D = CreateMatrixRndIntAcrossRows(3, 4, 1, 9);
PrintMatrix(array2D);

Console.WriteLine();

ChangeMatrixElemWithEvenIndexesForSquare(array2D);
PrintMatrix(array2D);

