// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int UserInput(string text) // Ввод пользователем числа int.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


void PrintArray(int[] collection) // Вывод массива на печать с квадратными скобками.
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) Console.Write(collection[i] + ", ");
        else Console.Write(collection[^1]); // Это обращение к последнему элементу массива.
    }
    Console.WriteLine("]");
}


int[] FibonacciArray(int count) // Создание массива и заполнение его числами Фибоначчи от первых элементов 0 и 1.
{
    int[] result = new int[count];
    result[1] = 1;
    for (int i = 2; i < count; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }
    return result;
}


int number = UserInput("Введите любое натуральное число: ");
int[] array = FibonacciArray(number);
PrintArray(array);

