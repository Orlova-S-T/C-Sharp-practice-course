// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Нечётными позициями здесь считаются нечётные индексы!
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] CreateArray(int size) // Создание массива (заполнен нолями).
{
    int[] collection = new int[size];
    return collection;
}


void FillArray(int[] collection, int min, int max) // Заполнение массива псевдослучайными числами.
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(min, max + 1);
    }
}


void PrintArray(int[] collection) // Вывод массива на печать с квадратными скобками.
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) Console.Write(collection[i] + ", ");
        else Console.Write(collection[^1]);
    }
    Console.WriteLine("]");
}


int SumOddIndexElem(int[] collection) // Подсчёт суммы элементов массива, имеющих нечётные индексы.
{
    int sumOddIndex = 0;
    for (int i = 1; i < collection.Length; i += 2)
    {
        sumOddIndex += collection[i];
    }
    return sumOddIndex;
}


int number = 4; // Задаём размер массива.
int minimum = -99; // Минимальное число диапазона чисел в массиве.
int maximum = 99; // Минимальное число диапазона чисел в массиве.

int[] array = CreateArray(number);
FillArray(array, minimum, maximum);
PrintArray(array);

int sum = SumOddIndexElem(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве, равна {sum}");

