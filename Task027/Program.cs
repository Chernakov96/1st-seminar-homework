// Задача 27: Напишите программу, которая
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// Пример:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    int sum = default;
    for (int i = 0; num != 0; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int result = SumOfDigits(number);
Console.WriteLine($"{result}");