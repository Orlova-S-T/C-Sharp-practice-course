// Задача 39: Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.).
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


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


void ReverseArray(int[] collection)
{
    for (int i = 0; i < collection.Length / 2; i++)
    {
        int temp = collection[i];
        collection[i] = collection[collection.Length - 1 - i];
        collection[collection.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrayRndInt(5, 1, 10);
PrintArray(array);

ReverseArray(array);
PrintArray(array);

Array.Reverse(array); // Это встроенный в C# метод.
PrintArray(array);

