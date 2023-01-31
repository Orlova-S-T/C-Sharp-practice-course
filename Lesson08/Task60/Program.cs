// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.

// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


// Поиск числа num среди элементов трёхмерного массива.
bool FindNumber(int[,,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == num) return true;
            }
        }
    }
    return false;
}


//Метод проверки, что число является двузначным (число может быть как положительным, так и отрицательным).
bool SelectionOfTwoDigitNumbers(int num)
{
    return Math.Abs(num) > 9 && Math.Abs(num) < 100;
}


// Создание трёхмерного массива и заполнение его неповторяющимися псевдослучайными числами.
// Откорректирован на заполнение только двузначными числами (как положительными, так и отрицательными).
// Это легко можно исправить, убрав из if второе условие. 
int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth, int min, int max) // Создание трёхмерного массива и заполнение его целыми псевдослучайными числами.
{
    int[,,] matrix3D = new int[rows, columns, depth]; // 0, 1, 2
    Random rnd = new Random();

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                int pretender = rnd.Next(min, max + 1);
                if (!FindNumber(matrix3D, pretender) && SelectionOfTwoDigitNumbers(pretender))
                // Если убрать второе условие - метод будет работать с любым заданным диапазоном чисел от min до max.
                {
                    matrix3D[i, j, k] = pretender;
                }
                else k--;
            }
        }
    }
    return matrix3D;
}


// Вывод трёхмерного массива на печать построчно (через пробел, каждая строчка обрамлена прямым слэшем |).
void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (j < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k})"); // 5 - количество знаков, отводимых на вывод каждого числа
                else Console.Write($"{matrix[i, j, k],5} ({i}, {j}, {k}) ");
            }

        }
        Console.WriteLine("  |");
    }
}




int[,,] array3D = CreateMatrix3DRndInt(rows: 3, columns: 2, depth: 2, min: -99, max: 99);

Console.WriteLine();
PrintMatrix3D(array3D);
Console.WriteLine();

