// Задача 62: Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Проверка двумерного массива на квадратность (равное количество строк и столбцов).
bool CheckMatrixForSquareness(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}


// Заполнение квадратного двумерного массива по спирали.
void FillMatrixAcrossHelix(int[,] matrix, int size, int indexI, int indexJ, int filler, int move)
{
    int i = indexI;
    int j = indexJ;
    int number = filler;

    while (j < size - indexJ) // На выходе для первого прогона рекурсии i = 0, j = size.
    {
        matrix[i, j] = number;
        j++;
        number += move;
    }

    j = j - 1; // Возвращаем j к значению j = size - 1. 
    i = i + 1;
    while (i < size - indexI) // На выходе для первого прогона рекурсии i = size, j = size - 1. 
    {
        matrix[i, j] = number;
        i++;
        number += move;
    }

    i = i - 1; // Возвращаем i к значению i = size - 1. При этом у нас остаётся j = size - 1.
    j = j - 1; // А значение j сдвигаем на 1 шаг влево, чтобы не перезаполнить нижний правый угол новым числом.
    while (j > indexJ) // На выходе для первого прогона рекурсии i = size - 1, j = 0.
    {
        matrix[i, j] = number;
        j--;
        number += move;
    }

    while (i > indexI) // На выходе для первого прогона рекурсии i = 0, j = 0. 
    {
        matrix[i, j] = number;
        i--;
        number += move;
    }

    indexI++; // На второй прогон заходит значение 1.
    indexJ++;  // На второй прогон заходит значение 1.
    filler = number;

    if (indexI <= size / 2 || indexJ <= size / 2) // Тут можно дать одно любое из этих условий.
    {
        FillMatrixAcrossHelix(matrix, size, indexI, indexJ, filler, move); // И рекурсия.
    }
}


// Вывод двумерного массива на печать (через пробел, каждая строчка обрамлена прямым слэшем |).
// С добавлением пустой строки до и после массива.
void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
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
    Console.WriteLine();
}




int rows = 5;    // Здесь задаём число строк в двумерном массиве (желательно больше 0, но и с 0 программа не ломается).
int columns = 5; // А здесь задаём число столбцов (тоже желательно больше 0). Для заполнения массива по спирали оно должно быть равно числу строк.
// При желании тут можно дать проверку, что rows и columns больше 0. Я пока не стала этого делать.

int[,] array2D = new int[rows, columns]; // 0, 1


int height = array2D.GetLength(0); // Высота получившейся матрицы, она равна в общем-то числу строк.
int lenth = array2D.GetLength(1);  // Длина получившейся матрицы, она равна в общем-то числу столбцов.
                                   // Для трёхмерной матрицы третьей характеристикой была бы ширина width.


if (CheckMatrixForSquareness(array2D))
{
    int startNumber = 1; // Число, с которого начинается заполнение массива.
    int step = 1; // Число, на которое увеличивается значение каждого последующего элемента массива.

    int startI = 0;         // Две строки задают индексы стартовой точки для заполнения матрицы по спирали.
                            // Здесь будут только точки, лежащие на главной диагонали (i = j).
    int startJ = startI;    // Элементы с индексами меньше заданных остануться равными 0.
                            // (Получится одно или несколько колец из нолей вокруг заполненного центра.)
                            // Если задать startI больше rows / 2 для чётного количества строк или больше rows / 2 + 1 для нечётного - матрица останется заполненной нулями. 


    FillMatrixAcrossHelix(matrix: array2D, size: height, indexI: startI, indexJ: startJ, filler: startNumber, move: step);
    PrintMatrix(array2D);
}


else
{
    Console.WriteLine($"Число строк {height} и столбцов {lenth} в двумерном массиве не совпадает, измените входные данные");
}

