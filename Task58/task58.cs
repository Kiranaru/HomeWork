// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int matrixFirstRowSize = 2,
    matrixFirstColSize = 2,
    matrixSecondRowSize = matrixFirstColSize,
    matrixSecondColSize = 2,
    matrixMinValue = 1,
    matrixMaxValue = 4;

int[,] rndFirstMatrixInt = CreatMatrixRndInt(matrixFirstRowSize, matrixFirstColSize, matrixMinValue, matrixMaxValue);
int[,] rndSecondMatrixInt = CreatMatrixRndInt(matrixSecondRowSize, matrixSecondColSize, matrixMinValue, matrixMaxValue);
int[,] matrixMultiplied = MatrixMultiplier(rndFirstMatrixInt, rndSecondMatrixInt);
Console.WriteLine("A:");
PrintMatrix(rndFirstMatrixInt);
Console.WriteLine("B:");
PrintMatrix(rndSecondMatrixInt);
Console.WriteLine("A*B:");
PrintMatrix(matrixMultiplied);


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

int[,] MatrixMultiplier(int[,] matrix1, int[,] matrix2)  // Two 2D Matrix Multiplication
{
    int sum = 0;
    int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
                sum += matrix1[i, k] * matrix2[k, j];
            newMatrix[i, j] = sum;
            sum = 0;
        }
    }
    return newMatrix;
}