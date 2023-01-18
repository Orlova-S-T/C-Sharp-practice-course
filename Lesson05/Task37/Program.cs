// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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


int[] PairMultiplicationElem(int[] collection) // Метод попарного перемножения элементов массива, результат в виде массива.
{
    int size = collection.Length / 2;
    if (collection.Length % 2 != 0) size = size + 1;
    // Вместо этих двух строк можно использовать тернарный оператор:
    // int size = collection.Length % 2 != 0 ? collection.Length / 2 + 1 : collection.Length / 2;
    int[] dataset = new int[size];
    for (int i = 0; i < size; i++)
    {
        dataset[i] = collection[i] * collection[collection.Length - 1 - i];
    }
    if (collection.Length % 2 != 0) dataset[size - 1] = collection[collection.Length / 2];
    return dataset;

}


int[] array = CreateArrayRndInt(5, -9, 9);
PrintArray(array);
PrintArray(PairMultiplicationElem(array));

