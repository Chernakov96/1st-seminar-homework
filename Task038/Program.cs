// Задача 38: 
// 1. Задайте массив вещественных чисел. 
// 2. Найдите разницу между максимальным и минимальным элементом массива.
// Пример:
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.ToZero);
    }

    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double FindDiffArrayMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    double diff = max - min;
    double diffRound = Math.Round(diff, 1, MidpointRounding.ToZero);
    return diffRound;
}

double[] arr = CreateArrayRndDouble(5, 0, 99);

PrintArrayDouble(arr);

double result = FindDiffArrayMinMax(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {result}");