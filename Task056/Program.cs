// Задача 56: 
// 1. Задайте прямоугольный двумерный массив. Напишите программу, которая 
// 2. будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

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

int[] FindRowSum(int[,] matrix)
{
    int[] result = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i] += matrix[i, j];
        }
    }

    return result;
}

void FindRowMinSum(int[] array)
{
    int minSum = array[0];
    int minSumIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            minSumIndex = i;
        }
    }
    Console.Write($"{minSumIndex+1} строка является строкой с наименьшей суммой элементов");
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);

int[] rowSum = FindRowSum(array2d);
PrintArray(rowSum);

FindRowMinSum(rowSum);