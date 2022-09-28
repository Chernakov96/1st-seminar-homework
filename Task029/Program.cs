// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 2. выводит их на экран.
// Пример: 
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

Console.WriteLine("Задайте число, являющееся минимальным элементом массива");
int arrayMin = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Задайте число, являющееся максимальным элементом массива");
int arrayMax = Convert.ToInt32(Console.ReadLine());

FillArray(arrayMin, arrayMax);
PrintArray(array);

void FillArray(int aMin, int aMax)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(aMin, aMax+1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}