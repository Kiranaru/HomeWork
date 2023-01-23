// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
int rows = 3;
int columns = 4;
int min = 1;
int max = 10;
double[,] arr1 = CreateMatrixRndReal(rows, columns, min, max);
PrintMatrix(arr1);
Console.WriteLine("Please, input number of Row position");
int rowNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please, input number of Column position");
int columnNumber = Convert.ToInt32(Console.ReadLine());
if (rowNumber < rows
    && rowNumber > 0
    && columnNumber < columns
    && columnNumber > 0)
    Console.WriteLine(arr1[rowNumber - 1, columnNumber - 1]);
else Console.WriteLine("There is no any number in this position.");


// Real 2D numbers matrix creation
double[,] CreateMatrixRndReal(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((max - min) * rnd.NextDouble(), 1);
        }
    }
    return matrix;
}

// Output for real numbers matrix
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("]");
    }
}