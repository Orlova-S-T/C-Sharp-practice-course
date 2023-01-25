// Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// Сумма элементов главной диагонали: 1 + 9 + 2 = 12


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


int GetSumMainDiagonal(int[,] matrix) // Метод получения суммы элементов главной диагонали.
{
    int sum = 0;
    int size = matrix.GetLength(0) <= matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}


string MainDiagonalElem(int[,] matrix) // Строка из суммирущихся элементов главной диагонали.
{
    string txt = String.Empty;
    int size = matrix.GetLength(0) <= matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
    for (int i = 0; i < size - 1; i++)
    {
        txt = txt + matrix[i, i] + " + ";
    }
    txt = txt + matrix[size - 1, size - 1];
    return txt;
}


Console.WriteLine();
int[,] array2D = CreateMatrixRndIntAcrossRows(4, 4, -9, 9);
PrintMatrix(array2D);

Console.WriteLine();

int result = GetSumMainDiagonal(array2D);
Console.WriteLine($"Сумма элементов главной диагонали: {MainDiagonalElem(array2D)} = {result}");
Console.WriteLine();

