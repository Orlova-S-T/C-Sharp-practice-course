// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Решение с семинара:
// System.Console.WriteLine("Выведите 3 числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.WriteLine("Да");
// else System.Console.WriteLine("Нет");


// Я бы сделала булев метод для выполнения всех 3 неравенств:
int UserInput(string text) // Ввод пользователем числа int.
{
    Console.Write(text);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}


bool TriangleInequality(int side1, int side2, int side3) // Метод проверки трёх чисел по теореме о неравенстве треугольника.
{
    return (side1 + side2 > side3) && (side2 + side3 > side1) && (side3 + side1 > side2);
}


int len1 = UserInput("Введите длину первой стороны треугольника: ");
int len2 = UserInput("Введите длину второй стороны треугольника: ");
int len3 = UserInput("Введите длину третьей стороны треугольника: ");

if (TriangleInequality(len1, len2, len3))
{
    Console.WriteLine($"Треугольник со сторонами {len1}, {len2} и {len3} существует");
}
else
{
    Console.WriteLine($"Треугольника со сторонами {len1}, {len2} и {len3} не существует");
}

