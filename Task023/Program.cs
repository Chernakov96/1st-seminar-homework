// Задача 23
// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// Пример:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

void TripleNumber(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int triple = i * i * i;
        Console.WriteLine($"{i}  {triple}");
    }
}
TripleNumber(number);