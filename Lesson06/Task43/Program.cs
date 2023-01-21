// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double UserInput(string text1, string text2) // Ввод пользователем числа double (запрос в 2 строки).
{
    Console.WriteLine(text1);
    Console.Write(text2);
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}


bool СheckLinesParallelism(double coefK1, double coefK2) // Проверка, что заданные пользователем прямые не параллельны.
{
    return coefK1 == coefK2;
}


bool СheckLinesOverlap(double coefK1, double coefK2, double coefB1, double coefB2) // Проверка, что заданные пользователем прямые не совпадают.
{
    return coefK1 == coefK2 && coefB1 == coefB2;
}


double AbscissaOfTwoLinesIntersectionPoint(double coefK1, double coefB1, double coefK2, double coefB2) // Метод нахождения абсциссы точки пересечения двух прямых.
{
    double variableX = (coefB2 - coefB1) / (coefK1 - coefK2);
    return variableX;
}


double OrdinateOfTwoLinesIntersectionPoint(double coefK, double coefB, double variableX) // Метод нахождения ординаты точки пересечения двух прямых.
{
    double variableY = coefK * variableX + coefB;
    return variableY;
}


double b1 = UserInput("Введите коэффициент b1 для уравнения первой прямой y = k1*x + b1", "b1 = ");
double k1 = UserInput("Введите коэффициент k1 для уравнения первой прямой y = k1*x + b1", "k1 = ");

double b2 = UserInput("Введите коэффициент b2 для уравнения второй прямой y = k2*x + b2", "b2 = ");
double k2 = UserInput("Введите коэффициент k2 для уравнения второй прямой y = k2*x + b2", "k2 = ");


if (СheckLinesParallelism(k1, k2))
{
    if (СheckLinesOverlap(k1, k2, b1, b2))
    {
        Console.WriteLine($"Заданные вами прямые y = {k1}*x + {b1} и y = {k2}*x + {b2} совпадают и все точки этих прямых являются для них общими");
    }
    else
    {
        Console.WriteLine($"Заданные вами прямые y = {k1}*x + {b1} и y = {k2}*x + {b2} параллельны и не имеют точек пересечения");
    }
}


else
{
    int round = 1; // Число знаков после запятой при округлении координат x и y точки пересечения заданых прямых.

    double abscissa = AbscissaOfTwoLinesIntersectionPoint(k1, b1, k2, b2);
    double x = Math.Round(abscissa, round, MidpointRounding.ToZero);

    double ordinate = OrdinateOfTwoLinesIntersectionPoint(k1, b1, abscissa);
    double y = Math.Round(ordinate, round, MidpointRounding.ToZero);

    // Console.WriteLine($"({abscissa}; {ordinate})");
    Console.WriteLine($"Прямые y = {k1}*x + {b1} и y = {k2}*x + {b2} пересекаются в точке с координатами ({x}; {y})");
}

