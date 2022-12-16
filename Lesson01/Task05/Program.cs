Console.Write("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int module = Math.Abs(number);

int count = - module;

while (count < module)
{
    Console.Write($"{count}, ");
    count++;
}
Console.WriteLine(count);

