// Задача 50. Напишите программу, которая 
// 1. на вход принимает позиции элемента в двумерном массиве, и 
// 2.возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

void FindElementValue(int[,] matrix, int rowNumber, int columnNumber)
{
    int value = default;

    if (rowNumber > matrix.GetLength(0) - 1 || columnNumber > matrix.GetLength(1) - 1
    || rowNumber < 0 || columnNumber < 0)
        Console.WriteLine("Такого элемента в массиве нет");

    else value = matrix[rowNumber, columnNumber];
    Console.WriteLine(value);
}

Console.WriteLine("Введите номер строки двумерного массива");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца двумерного массива ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] array2d = CreateMatrixRndInt(5, 5, 1, 100);
PrintMatrix(array2d);
FindElementValue(array2d, row-1, column-1); // -1 нужен, чтобы пользователь считал не с 0, а с единицы