// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

int[,] arr1 = CreatMatrixNM(3, 4, 1, 9);
PrintMatrix(arr1);
PrintAverageArithmetics(arr1);

// Создание двумерного массива как сумма номеров строки и столбца
int[,] CreatMatrixNM(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Печать массива int
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

// Выведение на печать средних арифметических по столбцам
void PrintAverageArithmetics(int[,] matr)
{
    double[] array = new double[matr.GetLength(1)];
    Console.WriteLine("=====================");
    Console.Write("[");
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            array[j] += matr[i, j];
        }
        if (j < matr.GetLength(1) - 1) Console.Write($"{Math.Round(array[j] / matr.GetLength(0), 1),4},");
        else Console.Write($"{Math.Round(array[j] / matr.GetLength(0), 1),4}");
    }
    Console.WriteLine("]  This is the arithmetic average for each column");
}