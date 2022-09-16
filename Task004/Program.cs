/*Задача 4: Напишите программу, которая 
1. принимает на вход три числа и 
2. выдаёт максимальное из этих чисел.
Пример:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if(number1 < number2)
{
    max = number2;
}
if(number2 < number3 && number1 < number3)
{
    max = number3;
}

Console.Write($"Максимальное число из введенных = {max}");
