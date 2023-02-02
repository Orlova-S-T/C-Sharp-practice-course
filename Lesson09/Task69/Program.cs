// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// Рекурсивный метод возведения целого числа num в натуральную степень pow.
int Exponentiation(int num, int pow)
{
    if (pow == 0) return 1; // Произведение при соблюдении условия умножается на 1.
    return num * Exponentiation(num, pow - 1); // Здесь (pow - 1) фактически определяет количество итераций.
                                               // И именно сюда вернётся 1 (из предыдущей строчки) вместо функции при выполнении условия pow == 0.
}


Console.Write("Enter integer number, the basis of the degree: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter natural number, degree indicator: ");
int b = Convert.ToInt32(Console.ReadLine());


while (b < 0) // Если пользователь ввёл отрицательный показатель степени.
{
    Console.WriteLine("You entered negative degree indicator!");
    Console.WriteLine("Please, reenter natural number (a integer number greater than zero):");
    b = Convert.ToInt32(Console.ReadLine());
}

int degree = Exponentiation(a, b);
Console.WriteLine($"The number {a} to the power of {b} is {degree}");


// // Вместо проверки знака показателя степени через while
// // можно дополнительно организовать возведение в отрицательную степень:
// int degree = Exponentiation(a, Math.Abs(b));
// double variable = Math.Round((double) 1 / degree, 3); // Без double в скобках внутри округления программа присвоит переменной variable
//                                                       // значение 0 (поскольку int 1 мы делим на int degree - и должны получить тоже int).
// Console.Write($"The number {a} to the power of {b} is ");
// Console.WriteLine(b >= 0 ? (degree) : $"1/{degree} = {variable}");

