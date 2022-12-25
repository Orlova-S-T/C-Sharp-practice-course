int UserInput(string text1, string text2)
{
    Console.WriteLine(text1);
    Console.Write(text2);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

bool NaturalSetCheck(int num)
{
    return num > 0;
}

void CubeN(int naturalNumber)
{
    double cubeN = Math.Pow(naturalNumber, 3);
    Console.WriteLine($"{naturalNumber,5} | {cubeN,10}");
}

void PlusOne(int lastInRange)
{
    int count = 1;
    while (count <= lastInRange)
    {
        CubeN(count);
        count++;
    }
}

int number = UserInput("Введите любое натуральное число", "N = ");

if (NaturalSetCheck(number)) PlusOne(number);
else Console.Write($"Ошибка ввода. Число {number} не является действительным. Необходимо ввести целое число больше ноля. Снова запустите программу и повторите попытку.");

