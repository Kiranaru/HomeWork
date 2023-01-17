// Задача 27: Напишите программу, которая
// принимает на вход число N и выдаёт
// сумму его цифр.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = NumberInput("Please, input your number:");
Console.WriteLine($"Your Factorial is:{SumNumbers(number)}");

int NumberInput(string text) // Method fot Number input
{
    Console.WriteLine("Please, input positive integer number (less than 9 millions)");
    int numberinput = Convert.ToInt32(Console.ReadLine());
    return numberinput;
}

int SumNumbers(int num) // Method for Summarize of all number's digits
{
    int sum = 0;
    while (num >= 1)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}