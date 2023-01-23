// Задайте одномерный массив, заполненный случайными числами. Найдите разницу между максимальным и минимальным элементом массива.

int[] arr = CreateArray(10, 1, 999);
PrintArray(arr);
Console.WriteLine($"Hallelujah! The difference between the maximum and minimum elements is: {DifferenceElem(arr)}");

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =rnd.Next(min,max+1);
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

int DifferenceElem(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    int diff = max - min;
    Console.WriteLine($"min: {min}, max: {max}");
    return diff;
}