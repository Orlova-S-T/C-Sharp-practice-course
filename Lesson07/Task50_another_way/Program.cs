// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1  4  7  2
// 5  9  2  3
// 8  4  2  4
// 1, 7 -> такого элемента в массиве нет

// Начальный фрагмент, где пользователь вводит оба числа в одной строке.
// В кавычки .Split() не удаётся “впихнуть” больше 1 знака-сепаратора
// (нет возможности задать '; ', проходит только ';').
// То есть если пользователь ввёл запятую с пробелом - программа ломается.
// Удалось это вылечить через .Replace(", ", " ") с заменой множества
// возможных неверно введённых пользователем комбинаций.
// Но все причуды пользователя я предусмотреть пока не могу.

string UserInput(string text) // Ввод пользователем строки.
{
    Console.WriteLine(text);
    string input = Console.ReadLine();
    return input;
}


int[] NumbersInStringToArray(string text) // Метод перевода перечисленных пользователем в строке ввода целых чисел в массив. 
{
    string revisedText = text.Replace("  ", " ")
                             .Replace(". ", " ")
                             .Replace(", ", " ")
                             .Replace(": ", " ")
                             .Replace("; ", " ")
                             .Replace("| ", " ");
    string[] stringArray = revisedText.Split(' ', '.', ',', ':', ';', '|');
    int size = stringArray.Length;
    int[] collection = new int[size];
    for (int i = 0; i < size; i++)
    {
        collection[i] = Convert.ToInt32(stringArray[i]);
    }
    return collection;
}




string userString = UserInput("Введите через запятую два целых числа:");
int[] array = NumbersInStringToArray(userString);
int i = array[0];
int j = array[1];
Console.WriteLine($"i = {i}, j = {j}");

