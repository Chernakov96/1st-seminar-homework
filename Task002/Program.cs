/* Задача 2: Напишите программу, которая 
1.на вход принимает два числа и 
2.выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
 a = 2 b = 10 -> max = 10
 a = -9 b = -3 -> max = -3
*/
Console.Write("Введите первое целое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
{
    Console.Write($"Число {number1} большее, а число {number2} меньшее ");
}
else if(number1 < number2)
{
    Console.Write($"Число {number1} меньшее, а число {number2} большее ");
}
else{
    Console.Write("Числа равны ");
}