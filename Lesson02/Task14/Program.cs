bool Div7And23Check(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.Write("Введите целое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (Div7And23Check(userNumber1)) Console.WriteLine($"{userNumber1} кратно одновременно 7 и 23");
else Console.WriteLine($"{userNumber1} не кратно одновременно 7 и 23");

