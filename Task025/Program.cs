// Задача 25: Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2.возводит число A в натуральную степень B.
// Пример:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число, возводимое в степень ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень числа ");
int numberB = Convert.ToInt32(Console.ReadLine());

int ExponentianteNumber(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

if (numberB <= 0) Console.WriteLine("Степень числа должна быть натуральной(строго больше нуля)");
else
{
    int result = ExponentianteNumber(numberA, numberB);
    Console.WriteLine($"{result}");
}