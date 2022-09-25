// Задача 15: Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2.проверяет, является ли этот день выходным.
// Пример:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели(пн = 1, вт = 2...) ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 6)
    {
        Console.WriteLine("нет");
    }
else if (number == 6 || number == 7)
    {
        Console.WriteLine("Да");
    }
else if (number < 1 || number > 7)
    {
        Console.WriteLine("Данное число не соответствует ни одному дню недели");
    }
