// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Please, input free koefficient for the FIRST Line:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, input multiplier for the FIRST Line:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, input free koefficient for the SECOND Line:");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Please, input multiplier for the SECOND Line:");
double k2 = double.Parse(Console.ReadLine());

if (b2 != 0
    && k2 != 0
    && k2 != k1
    && b1 / b2 != k1 / k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    Console.WriteLine($"Coordinates for crosspoit are (x,y)=({Math.Round(x, 1)},{Math.Round(y, 1)})");
}
else Console.WriteLine("There are no single crosspoint");