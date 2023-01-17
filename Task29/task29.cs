// Задача 29: Напишите программу, которая задает массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.

int[] arr = CreateArray(8);
PrintArray(arr);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 100);
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