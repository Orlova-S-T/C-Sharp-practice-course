// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7


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


// Поиск индексов минимального элемента в двумерном массиве, вывод через кортеж.
(int minElemIndexI, int minElemIndexJ, int minElem) FindMinElemIndexesInMatrix(int[,] matrix)
{
    int minElemIndexI = 0;
    int minElemIndexJ = 0;
    int minElem = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElem)
            {
                minElem = matrix[i, j];
                minElemIndexI = i;
                minElemIndexJ = j;
            }
        }
    }

    return (minElemIndexI, minElemIndexJ, minElem);
}


// Метод "удаления" одного заданного столбца и одной заданной строки двумерного массива.
int[,] DelitionOneRowAndOneColumnInMatrix(int[,] matrix, int rowNumber, int columnNumber)
{
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0; // Нумерация строк в создаваеммом массиве.
    int n = 0; // Нумерация столбцов в создаваеммом массиве.

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        if (m == rowNumber) m++;
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (n == columnNumber) n++;
            resultMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }

    return resultMatrix;
}




int[,] array2D = CreateMatrixRndIntAcrossRows(4, 4, -9, 9);
Console.WriteLine();
PrintMatrix(array2D);
Console.WriteLine();

var indexes = FindMinElemIndexesInMatrix(array2D);
Console.WriteLine("i = " + indexes.minElemIndexI + ", j = " + indexes.minElemIndexJ + "\n" + "min = " + indexes.minElem);
// Здесь представлено обращение к значениям, выведенным и метода через кортеж.
// Сочетание символов "\n" внутри скобок у Console.WriteLine даёт перенос на следующую строку. 

int[,] newArray2D = DelitionOneRowAndOneColumnInMatrix(array2D, indexes.minElemIndexI, indexes.minElemIndexJ);
Console.WriteLine();
PrintMatrix(newArray2D);
Console.WriteLine();

