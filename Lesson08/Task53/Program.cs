// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.


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


int[,] ExchangeFirstAndLastRowsInMatrix(int[,] matrix) // Обмен элементов первой и последней строк двумерного массива.
{
    int temp = 0;
    int height = matrix.GetLength(0);
    int length = matrix.GetLength(1);
    for (int j = 0; j < length; j++)
    {
        temp = matrix[0, j];
        matrix[0, j] = matrix[height - 1, j];
        matrix[height - 1, j] = temp;
    }
    return matrix;
}




Console.WriteLine();
int[,] array2D = CreateMatrixRndIntAcrossRows(3, 4, -99, 99);
PrintMatrix(array2D);
Console.WriteLine();


int[,] newArray2D = ExchangeFirstAndLastRowsInMatrix(array2D);
PrintMatrix(newArray2D);
Console.WriteLine();

