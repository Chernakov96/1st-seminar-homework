// Задача 68: 
// 1.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// 2. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите неотрицательное число ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число ");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = AkkFunc(numberM, numberN);
Console.WriteLine(result);


int AkkFunc(int numM, int numN)
{
    if (numM == 0) return numN + 1;

    else if (numM != 0 && numN == 0) return AkkFunc(numM - 1, 1);

    else if (numM > 0 && numN > 0) return AkkFunc(numM - 1, AkkFunc(numM, numN - 1));

    else if(numM < 0 || numN < 0) return 0;

    return AkkFunc(numM, numN);
}