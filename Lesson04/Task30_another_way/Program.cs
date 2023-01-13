// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке:
// [1,0,1,1,0,1,0,0]

// Другой вариант:
int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random(); // Создаём отдельную переменную, иначе может быть генерация
                               // одинаковых псевдослучайных чисел.
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[] arr = CreateArray(8);
PrintArray(arr);

