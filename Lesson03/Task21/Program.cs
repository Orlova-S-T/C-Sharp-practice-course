// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double UserInput(string text1, string text2)
{
    Console.WriteLine(text1);
    Console.Write(text2);
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}

double DistABin3D(double xa, double ya, double za, double xb, double yb, double zb)
{
    double distanceAB = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
    return Math.Round(distanceAB, 2, MidpointRounding.ToZero);
}


double x1 = UserInput("Введите координату Х первой точки", "x1 = ");
double y1 = UserInput("Введите координату Y первой точки", "y1 = ");
double z1 = UserInput("Введите координату Z первой точки", "z1 = ");

double x2 = UserInput("Введите координату Х второй точки", "x2 = ");
double y2 = UserInput("Введите координату Y второй точки", "y2 = ");
double z2 = UserInput("Введите координату Z второй точки", "z2 = ");


double result = DistABin3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {result}");

