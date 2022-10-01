// Задача 36: 
// 1. Задайте одномерный массив, заполненный случайными числами. 
// 2.Найдите сумму элементов, стоящих на нечётных позициях.
// Пример:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

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

int SumOfUnevenElem(int[] array)
{
    int sum = default;

    for (int i = 1; i < array.Length; i = i+2)
    {
        sum = sum + array[i];
    }

    return sum;
}

int[] arr = CreateArrayRndInt(10, -999, 999);

PrintArray(arr);

int result = SumOfUnevenElem(arr);
Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");

