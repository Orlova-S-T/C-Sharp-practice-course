Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int module = Math.Abs(number);
if (module > 99 && module < 1000)
{
    int lastDigit = module % 10;
    Console.WriteLine(lastDigit);
}
else
Console.WriteLine("Неправильно набран номер");
