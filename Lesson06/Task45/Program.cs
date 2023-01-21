// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.


int[] CreateArrayRndInt(int size, int min, int max) // Одновременное создание массива и заполнение его псевдослучайными числами.
{
    int[] collection = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(min, max + 1);
    }
    return collection;
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


int[] CopyArray(int[] input) // Создание копии заданного массива с помощью поэлементного копирования.
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = input[i];
    }
    return result;
}


int[] array = CreateArrayRndInt(7, -9, 9);
int[] copyArray = CopyArray(array);
copyArray[0] = 55;
Console.Write($"Копия массива: ");
PrintArray(copyArray);
Console.Write($"Исходный массив: ");
PrintArray(array);

