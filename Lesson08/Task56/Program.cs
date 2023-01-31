// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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


// Создание одномерного массива с элементами, являющимися суммами каждой из строк двумерного массива по отдельности.
int[] GetMatrixRowsSum(int[,] matrix)
{
    int length = matrix.GetLength(1);
    int height = matrix.GetLength(0);
    int[] collection = new int[height]; // Изначально новый массив collection заполнен нолями.

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            collection[i] = collection[i] + matrix[i, j];
        }
    }

    return collection;
}


// Вывод одномерного массива на печать с квадратными скобками.
void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) Console.Write(collection[i] + ", ");
        else Console.Write(collection[^1]); // Это обращение к последнему элементу массива.
    }
    Console.WriteLine("]");
}


// Поиск индекса минимального элемента в одномерном массиве из целых чисел.
int GetMinElemIndexInArray(int[] collection)
{
    int minElem = collection[0];
    int indexMinElem = 0;

    for (int i = 1; i < collection.Length; i++)
    {
        if (collection[i] < minElem)
        {
            minElem = collection[i];
            indexMinElem = i;
        }
    }

    return indexMinElem;
}




int[,] array2D = CreateMatrixRndIntAcrossRows(4, 4, -9, 9);

Console.WriteLine();
PrintMatrix(array2D);
Console.WriteLine();

int[] array = GetMatrixRowsSum(array2D);

Console.Write("Сумма элементов в каждой строке: ");
PrintArray(array);
Console.WriteLine();

int indexMinSumRow = GetMinElemIndexInArray(array);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMinSumRow + 1} строка");
Console.WriteLine();

