// *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int matrixRowSize = 2,
    matrixColSize = 2,
    matrixDepthSize = 2;
    
int[,,] rnd3DMatrixInt = Create3DMatrixRndInt(matrixRowSize, matrixColSize, matrixDepthSize);
Print3DMatrixByLayers(rnd3DMatrixInt);

int[,,] Create3DMatrixRndInt(int rowSize, int colSize, int depSize) //3d Matrix Creation 
{
    int[,,] resArray = new int[rowSize, colSize,depSize];
    Random rnd = new Random();
    for (int i = 0; i < resArray.GetLength(0); i++)
        for (int j = 0; j < resArray.GetLength(1); j++)
        for (int k = 0; k < resArray.GetLength(2); k++)
            resArray[i, j,k] = 10+i*4+j*2+k*1;
    return resArray;
}

void Print3DMatrixByLayers(int[,,] matrix)   // 3D Matrix Print Output by Layers
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            if (j == matrix.GetLength(1) - 1 & k == matrix.GetLength(2) - 1 ) Console.Write($"{matrix[i,j,k],4}({i},{j},{k})");
            else Console.Write($"{matrix[i,j,k],4}({i},{j},{k}),");
        }
        Console.WriteLine(" ]");
    }
}