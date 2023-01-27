// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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


bool CheckMatrixForSquareness(int[,] matrix) // Проверка двумерного массива на квадратность (равное количество строк и столбцов).
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}


void ExchangeRowsAndColumnsInMatrix(int[,] matrix) // Замена строк квадратного двумерного массива на столбцы ("переворот" матрицы на 90 градусов).
{
    int temp = 0;
    int height = matrix.GetLength(0);
    int length = matrix.GetLength(1);

    for (int i = 0; i < height - 1; i++)
    // В последней строке под условие j = i + 1 не будет подходящих элементов - матрица-то квадратная.
    // То есть, когда дойдём до последней строки, в ней уже всё будет заменено.
    // Поэтому можно задать не i < height, а i < height - 1;
    // Но с i < height пограмма тоже будет работать.
    {
        for (int j = i + 1; j < length; j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}




Console.WriteLine();
int[,] array2D = CreateMatrixRndIntAcrossRows(4, 4, -99, 99);
PrintMatrix(array2D);
Console.WriteLine();


if (CheckMatrixForSquareness(array2D))
{
    Console.WriteLine();
    ExchangeRowsAndColumnsInMatrix(array2D);
    PrintMatrix(array2D);
    Console.WriteLine();
}

else
{
    Console.WriteLine($"Число строк {array2D.GetLength(0)} и столбцов {array2D.GetLength(1)} в двумерном массиве на совпадает, поэтому строки и столбцы невозможно поменять местами");
}

