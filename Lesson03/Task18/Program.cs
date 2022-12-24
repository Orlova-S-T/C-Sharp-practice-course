string Range(int quart)
{
    if (quart == 1) return "X > 0, Y > 0";
    if (quart == 2) return "X < 0, Y > 0";
    if (quart == 3) return "X < 0, Y < 0";
    if (quart == 4) return "X > 0, Y < 0";
    return "Ошибка ввода. Номер координатной четверти должен быть целым числом от 1 до 4.";
}


Console.Write("Введите номер четверти координатной плоскости от 1 до 4: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = Range(quarter);

Console.WriteLine(result);



