int Quarter(int X, int Y)
{
    if (X > 0 && Y > 0) return 1;
    if (X < 0 && Y > 0) return 2;
    if (X < 0 && Y < 0) return 3;
    if (X > 0 && Y < 0) return 4;
    return 0;
}


Console.WriteLine("Введите координаты точки (не равные нулю)");
Console.Write("x = ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int userY = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(userX, userY);

string result = quarter > 0
        ? $"Точка с координатами x = {userX}, y = {userY} принадлежит {quarter} четверти координатной плоскости."
        : "Ошибка ввода. Координаты точки не должны быть равны 0.";
//Для лучшей читаемости тернарного оператора можно делать переносы для отдельных строк.

Console.WriteLine(result);
