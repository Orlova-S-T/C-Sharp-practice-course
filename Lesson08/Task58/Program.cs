// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18


// Создание двумерного массива и заполнение его целыми псевдослучайными числами.
int[,] CreateMatrixRndIntAcrossRows(int rows, int columns, int min, int max)
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


// Вывод двумерного массива на печать (через пробел, каждая строчка обрамлена прямым слэшем |).
void PrintMatrix(int[,] matrix)
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


// Проверка двух двумерных массивов на возможность их перемножения (равное количество столбцов первой матрицы и строк второй матрицы).
bool CheckTwoMatriсesForMultiplicationPossibility(int[,] matrix1, int[,] matrix2)
{
    return matrix1.GetLength(1) == matrix2.GetLength(0);
}


// Перемножение двух двумерных массивов.
int[,] GetTwoMatriсesMultiplication(int[,] matrix1, int[,] matrix2)
{
    int rows = matrix1.GetLength(0); // Количество строк в создаваемом массиве.
    int columns = matrix2.GetLength(1); // Количество столбцов в создаваемом массиве.

    int[,] result = new int[rows, columns]; // Изначально новый массив result заполнен нолями.

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int m = 0; m < matrix1.GetLength(1); m++) // Равнозначное условие - m < matrix2.GetLength(0)
            {
                result[i, j] = result[i, j] + matrix1[i, m] * matrix2[m, j];
            }
        }
    }

    return result;
}




int[,] firstArray2D = CreateMatrixRndIntAcrossRows(3, 4, 0, 9);

Console.WriteLine();
PrintMatrix(firstArray2D);
Console.WriteLine();

int[,] secondArray2D = CreateMatrixRndIntAcrossRows(4, 5, 0, 9);

Console.WriteLine();
PrintMatrix(secondArray2D);
Console.WriteLine();


if (CheckTwoMatriсesForMultiplicationPossibility(firstArray2D, secondArray2D))
{
    Console.Write($"Перемножение двух заданных матриц возможно: количество столбцов в первой матрице {firstArray2D.GetLength(1)} равно количеству строк во второй {secondArray2D.GetLength(0)}. ");
    int[,] multiplication = GetTwoMatriсesMultiplication(firstArray2D, secondArray2D);

    Console.WriteLine("Результатом перемножения двух заданных матриц является матрица:");
    Console.WriteLine();
    PrintMatrix(multiplication);
    Console.WriteLine();
}

else Console.WriteLine($"Перемножение двух заданных матриц невозможно: количество столбцов в первой матрице {firstArray2D.GetLength(1)} не равно количеству строк во второй {secondArray2D.GetLength(0)}");

