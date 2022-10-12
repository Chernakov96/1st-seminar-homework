// Задача 58: 
// 1.Задайте две матрицы. Напишите программу, которая 
// 2. будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows/*i < matrix.GetLength(0)*/; i++) //0 rows
    {
        for (int j = 0; j < columns/*i < matrix.GetLength(1)*/; j++) //1 columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}


int[,] MatrixMultiply(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] matrixMultiplied = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1)) 
    Console.WriteLine("Данные матрицы перемножить нельзя");

    else for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            int temp = default;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                temp += firstMatrix[i, k] * secondMatrix[k, j];
            }
            matrixMultiplied[i, j] = temp;
        }
    }

    return matrixMultiplied;
}

int[,] firstArray2d = CreateMatrixRndInt(2, 3, 1, 5);
PrintMatrix(firstArray2d);

Console.WriteLine();

int[,] secondArray2d = CreateMatrixRndInt(3, 2, 1, 5);
PrintMatrix(secondArray2d);

Console.WriteLine();

int[,] multiplicationResult = MatrixMultiply(firstArray2d, secondArray2d);
PrintMatrix(multiplicationResult);
