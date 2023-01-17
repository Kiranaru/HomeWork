// Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет число четных чисел в массиве

int[] arr = CreateArray(10, 100, 999);
PrintArray(arr);
Console.WriteLine($"Hallelujah! Your number of even elements is: {CountEvenElem(arr)}");


int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.WriteLine(array[i] + "]");
    }
}

int CountEvenElem(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}