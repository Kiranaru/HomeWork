// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int numMin = 2;
Console.WriteLine($"Please, input positive Number more then {numMin}");

int number = NumeroInput(numMin);

NaturalNumbersOutput(number);

int NumeroInput(int numM)
{
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < numM)
    {
        Console.WriteLine("I told you, input positive Number more then 1! Try again:");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

void NaturalNumbersOutput(int num)
{
    if (num == 1) { Console.Write($"{num}"); return; }
    Console.Write($"{num}, ");
    NaturalNumbersOutput(num - 1);
}


