// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


int[,] arr1 = CreateMatrixRndInt(4, 2, 1, 50);
PrintMatrix(arr1);
Console.Write(MatrixTrace(arr1));

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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

// Суммирование элементов на диагонали
int MatrixTrace(int[,] matrix)
{
    int sum = 0;
    int k = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : k = matrix.GetLength(1);
    for (int i = 0; i < k; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
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