// Задайте одномерный массив, заполненный случайными действительными числами, записанными с точностью до одного знака после запятой. Найдите разницу между максимальным и минимальным элементом массива.

double[] arr = CreateArray(10, 1, 999);
PrintArray(arr);
Console.WriteLine($"Hallelujah! The difference between the maximum and minimum elements is: {DifferenceElem(arr)}");

double[] CreateArray(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =Math.Round((max - min) * rnd.NextDouble(), 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.WriteLine(array[i] + "]");
    }
}

double DifferenceElem(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    Console.WriteLine($"min: {min}, max: {max}");
    return diff;
}