﻿// Задача 43: Напишите программу, которая 
// 1. значения b1, k1, b2 и k2 задаются пользователем.
// 2. найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//k2 * x + b2 = k1 * x + b1
//k2x - k1x = b1 - b2
//x = b2-b1/k1-k2
//
//9x - 5x = 2 - 4
//x = -0.5
//y = 5*-0.5+2
//y = -0.5



Console.WriteLine("Введите значение b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1 ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2 ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if(k1 == k2) Console.WriteLine("У данных прямых нет точек пересечения");
else Console.WriteLine($"Пересечение двух прямых в точке: ({x};{y})");
