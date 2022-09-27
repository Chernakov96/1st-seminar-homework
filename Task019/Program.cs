// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// Пример:
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

string IfPalindrome(int num)
{
    if(num > 99999 || num < 10000) return $"{num} не является пятизначным числом";
    int FirstDigit = num / 10000;
    int SecondDigit = (num / 1000) % 10;
    int FourthDigit = (num / 10) % 10;
    int FifthDigit = num % 10;
    if(FirstDigit == FifthDigit && SecondDigit == FourthDigit) return $"{num} является палиндромом";
    else return $"{num} не является палиндромом";
}

string result = IfPalindrome(number);
System.Console.WriteLine(result);