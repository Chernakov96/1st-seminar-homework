// Задача 62. Напишите программу, которая 
// 1.заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixSpiral(int rows, int columns)
{
    int[,] spiralMatrix = new int[rows, columns];
    int i = 0;
    int j = 0;
    int counter = 1;

    for (j = 0; j < spiralMatrix.GetLength(0); j++)
    {
        spiralMatrix[i, j] = counter;
        counter++;
    }

    for (i = 1; i < spiralMatrix.GetLength(0); i++)
    {
        j = spiralMatrix.GetLength(0) - 1;
        spiralMatrix[i, j] = counter;
        counter++;
    }

    for (j = spiralMatrix.GetLength(0) - 2; j >= 0; j--)
    {
        i = spiralMatrix.GetLength(0) - 1;
        spiralMatrix[i, j] = counter;
        counter++;
    }

    for (i = spiralMatrix.GetLength(0) - 2; i >= 1; i--)
    {
        j = 0;
        spiralMatrix[i, j] = counter;
        counter++;
    }

    for (j = 1; j < spiralMatrix.GetLength(0) - 1; j++)
    {
        i = 1;
        spiralMatrix[i, j] = counter;
        counter++;
    }

    for (j = spiralMatrix.GetLength(0) - 2; j >= 1; j--)
    {
        i = spiralMatrix.GetLength(0) - 2;
        spiralMatrix[i, j] = counter;
        counter++;
    }

    return spiralMatrix;
}

void PrintMatrix(int[,] spiralMatrix)
{

    for (int i = 0; i < spiralMatrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < spiralMatrix.GetLength(1); j++)
        {
            if (j < spiralMatrix.GetLength(1) - 1) Console.Write($"{spiralMatrix[i, j],4}, ");
            else Console.Write($"{spiralMatrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[,] array2DSpiral = CreateMatrixSpiral(4,4);
PrintMatrix(array2DSpiral);