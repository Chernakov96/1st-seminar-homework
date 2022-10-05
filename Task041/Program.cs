// Задача 41: 
// 1. Пользователь вводит с клавиатуры M чисел. 
// 2. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите произвольное количество чисел через запятую(после каждой запятой нужен пробел) ");
string numbers = Console.ReadLine();

int[] array = ConvertStringOfNumbersToArray(numbers);
PrintArray(array);

int result = PositiveNumbers(array);
Console.WriteLine($"Количество чисел больше нуля равно {result}");

int[] ConvertStringOfNumbersToArray(string input)
{
    string deleteCommas = input.Replace(",", "");
    int[] numbersToArray = deleteCommas.Split(' ').Select(int.Parse).ToArray();
    
    return numbersToArray;
}

int PositiveNumbers(int[] array)
{
    int sumOfPositives = default;
    for (int i = 0; i < array.Length; i++) if(array[i] > 0) sumOfPositives++;

    return sumOfPositives;
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
