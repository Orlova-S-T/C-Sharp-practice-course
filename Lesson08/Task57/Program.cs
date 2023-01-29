// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// * Набор данных: { 1, 9, 9, 0, 2, 8, 0, 9 }
// Частотный массив:
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// * Набор данных:
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// Частотный массив:
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


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


int[] MatrixToArray(int[,] matrix) // Метод перевода двумерного массива в одномерный построчно.
{
    int[] collection = new int[matrix.Length]; // matrix.Length выводит общее число элементов в массиве.
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            collection[k] = matrix[i, j];
            k++;
        }
    }
    return collection;
}


void PrintArray(int[] collection) // Вывод одномерного массива на печать с квадратными скобками.
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) Console.Write(collection[i] + ", ");
        else Console.Write(collection[^1]); // Это обращение к последнему элементу массива.
    }
    Console.WriteLine("]");
}


// Подсчёт количества неповторяющихся чисел в одномерном отсортированном массиве.
int CountOfOriginalNumbersInArray(int[] dataset)
{
    int number = dataset[0];
    int count = dataset.Length;

    for (int i = 1; i < dataset.Length; i++)
    {
        if (dataset[i] == number) count--;
        else number = dataset[i];
    }
    return count;
}


// Составление частотного словаря (сколько раз встречается в отсортированном одномерном массиве каждое из чисел).
int[,] CreateDictionaryFromArray(int[] collection)
{
    int rows = CountOfOriginalNumbersInArray(collection); // Число строк в частотном массиве равно количеству неповторяющихся чисел в нём. 
                                                          // Это количество находим в отдельной функции.
    int[,] dictionaryMatrix = new int[rows, 2]; // И в каждой строке 2 столбца - в первом значение из массива, во втором - число его повторений.
    int currentValue = collection[0];
    dictionaryMatrix[0, 0] = currentValue;
    dictionaryMatrix[0, 1] = 1;

    int i = 0;
    for (int k = 1; k < collection.Length; k++)
    {
        if (collection[k] == currentValue)
        {
            dictionaryMatrix[i, 1]++;
        }
        else
        {
            currentValue = collection[k];
            i++;
            dictionaryMatrix[i, 0] = collection[k];
            dictionaryMatrix[i, 1] = 1;
        }
    }
    return dictionaryMatrix;
}




Console.WriteLine();
int[,] array2D = CreateMatrixRndIntAcrossRows(3, 3, -5, 5);
PrintMatrix(array2D);
Console.WriteLine();

int[] array = MatrixToArray(array2D);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();

int[,] dictionaryMatrix = CreateDictionaryFromArray(array);
Console.WriteLine();
PrintMatrix(dictionaryMatrix);
Console.WriteLine();

