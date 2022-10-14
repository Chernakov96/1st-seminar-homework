// Задача 66: 
// 1.Задайте значения M и N. Напишите программу, которая 
// 2. найдёт сумму натуральных элементов в промежутке от M до N.
// Пример:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ");
int numberN = Convert.ToInt32(Console.ReadLine());

int result = RangeSumElems(numberM, numberN);
Console.Write(result);



int RangeSumElems(int numM, int numN)
{
    if (numM < numN)
    {
        numN = numN + RangeSumElems(numM,numN-1);
        return numN;
    }

    if (numM > numN)
    {
         numM = numM + RangeSumElems(numM-1,numN);
         return numM;
    }

    if (numM == numN)
    {
        return numN;
    }
    
    return 0;
}