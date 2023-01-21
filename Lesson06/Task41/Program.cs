// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


string UserInput(string text) // Ввод пользователем строки.
{
    Console.WriteLine(text);
    string input = Console.ReadLine();
    return input;
}


int[] NumbersInStringToArray(string text) // Метод перевода перечисленных пользователем в строке ввода целых чисел в массив. 
{
    string[] stringArray = text.Split(); // Если в пользовательском вводе в качестве разделителя между числами указаны
                                         // другие символы - внесите их в каывычках в скобки метода .Split().
    int size = stringArray.Length;
    int[] collection = new int[size];
    for (int i = 0; i < size; i++)
    {
        collection[i] = Convert.ToInt32(stringArray[i]);
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
    Console.Write("]");
}


int CountPositiveElements(int[] collection) // Подсчёт количества положительных элементов в массиве.
{
    int count = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] > 0) count++;
    }
    return count;
}


string userString = UserInput("Введите любое количество целых числел, разделяя их только одним пробелом:");
// Можно предложить пользователю вести числа только через пробел, через запятую без пробела, через запятую и пробел, через точку с запятой и т.д.
// В таком случае выбранный разделитель между числами нужно внести в кавычах в скобки метода .Split() в первой строке метода NumbersInStringToArray.
// Например, .Split(", ") при использовании в качестве разделителя запятой и пробела. 


int[] array = NumbersInStringToArray(userString);
PrintArray(array);

int countPosElem = CountPositiveElements(array);
Console.WriteLine($" -> вами введены {countPosElem} положительных числа");

