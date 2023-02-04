// Задача 20: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


double DistanceAB(double xa, double ya, double xb, double yb)
{
    double distAB = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));
    return Math.Round(distAB, 2, MidpointRounding.ToZero);
}

Console.WriteLine("Введите координату X первой точки");
Console.Write("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки");
Console.Write("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки");
Console.Write("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки");
Console.Write("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());

double result = DistanceAB(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками с координатами ({x1}, {y1}) и ({x2}, {y2}) равно {result}");


// Начало (ввод) тоже можно было реализовать через метод:
// int InsertPositon(string text)
// {
//     Console.WriteLine(text);
//     int pos = Convert.ToInt32(Console.ReadLine());
//     return pos;
// }

// int x1 = InsertPositon("Введите координату Х первой точки:");
// int y1 = InsertPositon("Введите координату Y первой точки:");

// int x2 = InsertPositon("Введите координату Х второй точки:");
// int y2 = InsertPositon("Введите координату Y второй точки:");

