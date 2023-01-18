// Задача 31: Задайте массив из 12 элементов,
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.


int[] CreateArrayRndInt(int size, int min, int max) // Создание массива и заполнение его случайными числами.
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array) // Вывод массива на печать с квадратными скобками.
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[^1]); // Это обращение к последнему элементу массива.
    }
    Console.WriteLine("]");
}


int GetSumPositiveElem(int[] array)
{
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sumPos += array[i];
    }
    return sumPos;
}


int GetSumNegativeElem(int[] array)
{
    int sumNeg = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
    }
    return sumNeg;
}


int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNegativeElem(arr);

Console.WriteLine($"Сумма положительных элементов равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна {sumNegative}");

