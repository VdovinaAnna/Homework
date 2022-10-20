using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
    Даны два неотрицательных числа m и n.*/

int AckermanFunc(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermanFunc(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermanFunc(numberM - 1, AckermanFunc(numberM, numberN - 1));
    return AckermanFunc(numberM,numberN);
}

int m = 2;
int n = 3;
Console.WriteLine($"Функция Аккермана для чисел ({m},{n}) = {AckermanFunc(m,n)}");
 }
}
}

