// Задача 60. 
// 1. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая 
// 2. будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateMatrix3DUniqueNUmbers(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix3D = new int[rows, columns, depth];
    int counter = 10;

    for (int i = 0; i < rows/*i < matrix3D.GetLength(0)*/; i++) //0 rows
    {
        for (int j = 0; j < columns/*i < matrix3D.GetLength(1)*/; j++) //1 columns
        {
            for (int k = 0; k < depth/*i < matrix3D.GetLength(2)*/; k++) //2 3rd dimension
            {
                matrix3D[i, j, k] = counter;
                counter++;
            }

        }
    }

    return matrix3D;
}

void Print3DMatrix(int[,,] matrix3D)
{

    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k]}[{i} {j} {k}] ");
            }

        }
        Console.WriteLine("]");
    }
}

int[,,] array3d = CreateMatrix3DUniqueNUmbers(2, 2, 2, 10, 99);
Print3DMatrix(array3d);