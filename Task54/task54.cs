// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

//Initial parameters for integer matrix generation.
int matrixRowSize = 3,
    matrixColSize = 4,
    matrixMinValue = -99,
    matrixMaxValue = 99;

int[,] rndMatrixInt = CreatMatrixRndInt(matrixRowSize, matrixColSize, matrixMinValue, matrixMaxValue);
PrintMatrix(rndMatrixInt);
Console.WriteLine("Sorted in Descending order:");
ResortMatrixEachRowDescend(rndMatrixInt);
PrintMatrix(rndMatrixInt);


int[,] CreatMatrixRndInt(int rowSize, int colSize, int minValue, int maxValue) //2d Matrix Creation with Random Integer Elements
{
    int[,] resArray = new int[rowSize, colSize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
            resArray[i, j] = rnd.Next(minValue, maxValue + 1);
    return resArray;
}

void PrintMatrix(int[,] matrix)   // 2D Matrix Print Output
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

void ResortMatrixEachRowDescend(int[,] matrix) // 2D Matrix Each row Descernding resorting
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp;
        int marker = 1;
        while (marker != 0)
        {
            marker = 0;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    marker = 1;
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
}