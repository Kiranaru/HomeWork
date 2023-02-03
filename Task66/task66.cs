// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;
int numMin = 1;
Console.WriteLine($"Please, input positive Natural Number");
int numberFirst = NumeroInput(numMin);
Console.WriteLine($"Please, input positive the second Natural Number greater tnen previous");
int numberSecond = NumeroInput(numberFirst);

NaturalNumbersSumOutput(numberFirst, numberSecond);

int NumeroInput(int numM)
{
    int num = Convert.ToInt32(Console.ReadLine());
    while (num < numM)
    {
        Console.WriteLine("I told you, input appropriate Natural Number! A little bit Greater! Try again:");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

void NaturalNumbersSumOutput(int numF, int numS)
{
    if (numF > numS) { Console.WriteLine($"The Summ of the numbers in your brunch is:{sum}"); return; }
    sum += numF++;
    NaturalNumbersSumOutput(numF, numS);
}