// Задача 10: Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.
// Пример:
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число(100-999) ");
int number = Convert.ToInt32(Console.ReadLine());

int ShowSecondNumber(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int secondDigit = (num - firstDigit * 100 - thirdDigit)/10;
    return secondDigit;
}

int result = ShowSecondNumber(number);
Console.WriteLine($"{result}");