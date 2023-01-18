// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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


bool FindNumber(int[] collection, int num) // Поиск определённого числа num среди элементов массива.
{
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == num) return true;
    }
    return false;
}


int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);


int number = 8;
if (FindNumber(array, number)) Console.WriteLine($"Да, в исследованном массиве присутствует число {number}");
else Console.WriteLine($"Нет, в исследованном массиве нет числа {number}");

// Вариант с урока - с тернарным оператором:
// Console.WriteLine("Введите искомое число:");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindNumber(array, numb) ? "да" : "нет");

