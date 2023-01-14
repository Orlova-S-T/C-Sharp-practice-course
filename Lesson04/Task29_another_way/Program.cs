// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int UserInput(string text) // Ввод пользователем данных типа int.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


int[] CreateArray(int size) // Создание массива (заполнен нолями).
{
    int[] dataset = new int[size];
    return dataset;
}


void FillArray(int[] collection, int min, int max) // Заполнение массива псевдослучайными числами.
{
    Random rnd = new Random();
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = rnd.Next(min, max + 1);
    }
}


void PrintArray(int[] collection) // Двойной вывод массива на печать через два цикла.
{
    for (int i = 0; i < collection.Length - 1; i++)
    {
        Console.Write($"{collection[i]}, ");
    }
    Console.Write($"{collection[collection.Length - 1]} -> [");
    for (int j = 0; j < collection.Length - 1; j++)
    {
        Console.Write($"{collection[j]}, ");
    }
    Console.WriteLine($"{collection[collection.Length - 1]}]");
}


void CyclicPrintArray(int[] collection) // Двойной вывод массива на печать через цикл в цикле с условием.
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j <= collection.Length - 1; j++)
        {
            if (j != collection.Length - 1) Console.Write($"{collection[j]}, ");
            else if (i == 0) Console.Write($"{collection[collection.Length - 1]} -> [");
            else Console.WriteLine($"{collection[collection.Length - 1]}]");
        }
    }
}


int userSize = UserInput("Задайте длинну массива (введите любое натуральное число): ");
int userMinimum = UserInput("Задайте минимальное число в диапазоне для заполнения массива случайными числами: ");
int userMaximum = UserInput("Задайте максимальное число в диапазоне для заполнения массива случайными числами: ");

int[] array = CreateArray(userSize);
FillArray(array, userMinimum, userMaximum);
PrintArray(array);
CyclicPrintArray(array); // Или PrintArray(array); или CyclicPrintArray(array); - у меня они здесь оба для сравнения.

