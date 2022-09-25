// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.
// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int showThirdDigit(int num)
{
    while (num / 1000 >= 1)num = num / 10; 
    int thirdDigit = num % 10;
    return thirdDigit;
}

if(number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int result = showThirdDigit(number);
    Console.WriteLine($"{result}");
}