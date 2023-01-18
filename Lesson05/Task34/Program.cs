// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


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


int CountEvenElements(int[] collection) // Подсчёт количества чётных элементов в массиве.
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] % 2 == 0) count++;
    }
    return count;
}


int number = 12; // Задаём размер массива.
int minimum = 100; // Минимальное число диапазона чисел в массиве.
int maximum = 999; // Максимальное число диапазона чисел в массиве.

int[] array = CreateArray(number);
FillArray(array, minimum, maximum);
PrintArray(array);
int countEven = CountEvenElements(array);

Console.WriteLine($"Число чётных элементов в массиве равно {countEven}");

