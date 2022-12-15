Console.Write("Введите номер дня недели от 1 до 7: ");
string weekday = Console.ReadLine();

if (weekday == "1")
{
    Console.WriteLine($"{weekday}й день недели - понедельник");
}
else if (weekday == "2")
{
    Console.WriteLine($"{weekday}й день недели - вторник");
}
else if (weekday == "3")
{
    Console.WriteLine($"{weekday}й день недели - среда");
}
else if (weekday == "4")
{
    Console.WriteLine($"{weekday}й день недели - четверг");
}
else if (weekday == "5")
{
    Console.WriteLine($"{weekday}й день недели - пятница");
}
else if (weekday == "6")
{
    Console.WriteLine($"{weekday}й день недели - суббота");
}
else if (weekday == "7")
{
    Console.WriteLine($"{weekday}й день недели - воскресенье");
}
else
{
    Console.WriteLine("Ошибка. Номером дня недели может быть целое число от 1 до 7");
}

