// Задача 32: Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] CreateArrayRndInt(int size, int min, int max) // Создание массива и заполнение его случайными числами.
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
    System.Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) System.Console.Write(collection[i] + ", ");
        else System.Console.Write(collection[i]);
    }
    System.Console.WriteLine("]");
}


void ReversSignElem(int[] collection) // Изменение знаков элементов массива на противоположные.
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = -collection[i];
    }
}


int[] array = CreateArrayRndInt(4, -10, 10);
PrintArray(array);

ReversSignElem(array);
PrintArray(array);

