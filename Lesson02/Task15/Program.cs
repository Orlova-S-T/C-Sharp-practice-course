bool CheckFrom1To7(int num) //Метод проверки, что число лежит в интервале [1, 7].
{
    return num > 0 && num < 8;
}


Console.Write("Введите номер дня недели от 1 до 7: ");
int weekday = Convert.ToInt32(Console.ReadLine());

if (!CheckFrom1To7(weekday)) Console.WriteLine("Ошибка ввода. Номером дня недели может быть только целое число от 1 до 7. Перезапустите программу и повторите попытку.");
else if (weekday == 6 || weekday == 7) Console.WriteLine("Этот день является выходным.");
else Console.WriteLine("Этот день не является выходным.");

