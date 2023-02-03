// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

//Initial parameters for integer matrix generation.
int matrixRowSize = 4,
    matrixColSize = 4,
    matrixMinValue = 1,
    matrixMaxValue = 99;

int[,] rndMatrixInt = CreatMatrixRndInt(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);
int[] rowMax = GetEachRowSum(rndMatrixInt);
PrintMatrixWithMax(rndMatrixInt, rowMax);
Console.WriteLine($"Position with Maximum sum is: {MaximumPosition(rowMax) + 1}");


int[,] CreatMatrixRndInt(int rowSize, int colSize, int minValue, int maxValue) //2d Matrix Creation with Random Integer Elements
{
    int[,] resArray = new int[rowSize, colSize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
            resArray[i, j] = rnd.Next(minValue, maxValue + 1);
    return resArray;
}

int[] GetEachRowSum(int[,] matrix) // Create sum for each Row
{
    int[] resArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        resArray[i] = sum;
    }
    return resArray;
}

int MaximumPosition(int[] array)
{
    int pos = 0;
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            pos = i;
            max = array[i];
        }
    }
    return pos;
}


void PrintMatrixWithMax(int[,] matrix, int[] column)   // 2D Matrix Print Output with additional column
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine($"]  RowSum = {column[i]}");
    }
}
