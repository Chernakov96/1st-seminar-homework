// Задача 47. 
// 1. Задайте двумерный массив размером m×n, 
// 2.заполненный случайными вещественными числами.
// Пример:
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateDoubleMatrixRndInt(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows/*i < matrix.GetLength(0)*/; i++) //0 rows
    {
        for (int j = 0; j < columns/*i < matrix.GetLength(1)*/; j++) //1 columns
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
        }
    }

    return matrix;
}

void PrintDoubleMatrix(double[,] matrix)
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

double[,] array2d = CreateDoubleMatrixRndInt(3, 4, -5.5, 9.2);
PrintDoubleMatrix(array2d);