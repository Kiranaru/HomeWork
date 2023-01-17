// Задача 35: Напишите цикл, который на вход принимает два числа А и В и выдает число, равное А, возведенное в натуральную степень В.

Console.WriteLine("Please, input positive integer number (less than 9 millions)");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please, input the power");
double power = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Your result is:{PowerMaker(number, CheckPower(power))}");

double CheckPower(double pow)
{
    while (pow != Math.Round(pow))
    {
        Console.Write("Wrong number. You have to enter real Natural number, try again, please:");
        Console.WriteLine($"power={pow}, math.round= {Math.Round(pow)} Please, input the power");
        pow = Convert.ToDouble(Console.ReadLine());
    }
    return pow;
}

double PowerMaker(double num, double pow)
{
    double itog = 1;
    for (int i = 1; i <= pow; i++)
    {
        itog = itog * num;
    }
    return itog;
}