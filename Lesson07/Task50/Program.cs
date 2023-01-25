// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// 1, 7 -> такого элемента в массиве нет


int UserInput(string text) // Ввод пользователем числа int.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


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


bool CheckElemIndexes(int[,] matrix, int indexI, int indexJ) // Проверка есть ли в двумерном массиве элемент с заданными пользователем номерами строки и столбца.
{
    return (indexI < matrix.GetLength(0)) && (indexJ < matrix.GetLength(1));
}




Console.WriteLine();
int[,] array2D = CreateMatrixRndIntAcrossRows(rows: 3, columns: 4, min: -9, max: 9);
PrintMatrix(array2D);
Console.WriteLine();


int i = UserInput("Введите индекс строки: ");
int j = UserInput("Введите индекс столбца: ");
Console.WriteLine();


if (CheckElemIndexes(array2D, i, j))
{
    Console.WriteLine($"Элемент массива с индексами [{i}, {j}] равен {array2D[i, j]}");
}

else
{
    Console.WriteLine($"Элемента с индексами [{i}, {j}] в массиве нет");
}
Console.WriteLine();

