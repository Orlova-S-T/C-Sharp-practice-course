// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].
// (Пример делаем для массива из 5, а не 123 элементов. В окончательном решении сделайте 123 элемента.)
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) Console.Write(collection[i] + ", ");
        else Console.Write(collection[i]);
    }
    Console.WriteLine("]");
}


int CountTwoDigitNumbers(int[] collection) // Подсчёт количества положительных двузначных чисел в массиве.
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 9 && collection[i] < 100) count++;
    }
    return count;
}


int[] array = CreateArrayRndInt(5, -200, 200);
PrintArray(array);

int amount = CountTwoDigitNumbers(array);
Console.WriteLine($"Количество положительных двузначных чисел в массиве равно {amount}");




// Из решения в группе - можно преобразовать массив в строку аналогом нашего PrintArray,
// если сделать метод не void, а string (решение рабочее):

string ArrayToString(int[] collection) // Метод преобразования массива в строку.
{
    string result = "[";
    for (int i = 0; i < collection.Length; i++)
    {
        result = result + $" {collection[i]}";
        result = i < (collection.Length - 1) ? result = result + "," : result; //для корректности вывода запятых
    }
    return result + " ]";
}


string strArray = ArrayToString(array); // переводим массив в строку для дальнейшего вывода на экран
Console.WriteLine($"{strArray} -> {amount}");

