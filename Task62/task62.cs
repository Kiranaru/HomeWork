// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//Initial parameters for integer matrix generation.
// You can enter EVERY positive integer number for cvolumns or rows.
int matrixRowSize = 4,
    matrixColSize = 4,
    matrixStartValue = 1;

int[,] spiralMatrixInt = CreateSpiralMatrix(matrixRowSize, matrixColSize, matrixStartValue);
PrintMatrix(spiralMatrixInt);

int[,] CreateSpiralMatrix(int rowSize, int colSize, int startValue) //2d Matrix Creation with Random Integer Elements
{
    int k = startValue;
    int iUpper = 0;
    int iBottom = rowSize - 1;
    int jLeft = 0;
    int jRight = colSize - 1;
    int[,] resArray = new int[rowSize, colSize];
    int i = iUpper;
    int j = jLeft;

    while (iUpper < iBottom && jLeft < jRight)
    {
        for (j = jLeft; j <= jRight; j++)
            resArray[i, j] = k++;
        j--;
        iUpper++;
        for (i = iUpper; i <= iBottom; i++)
            resArray[i, j] = k++;
        i--;
        jRight--;
        for (j = jRight; j >= jLeft; j--)
            resArray[i, j] = k++;
        j++;
        iBottom--;
        for (i = iBottom; i >= iUpper; i--)
            resArray[i, j] = k++;
        i++;
        jLeft++;
    }

    if (iUpper == iBottom && j == jLeft - 1)
    {
        for (j = jLeft; j <= jRight; j++)
            resArray[i, j] = k++;
        iUpper++;
    }
    if (iUpper == iBottom && j == jRight + 1)
    {
        for (j = jRight; j >= jLeft; j--)
            resArray[i, j] = k++;
        iBottom--;
    }
    if (jLeft == jRight && i == iUpper)
    {
        for (i = iUpper; i <= iBottom; i++)
            resArray[i, j + 1] = k++;
        jLeft++;
    }
    if (jLeft == jRight && i == iBottom)
    {
        for (i = iBottom; i >= iUpper; i--)
            resArray[i, j - 1] = k++;
        jRight--;
    }
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
        Console.WriteLine($"] ");
    }
}
