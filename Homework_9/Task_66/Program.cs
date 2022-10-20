using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 66: Задайте значения M и N. Напишите программу, 
    которая найдёт сумму натуральных элементов в промежутке от M до N.*/

double SumFor(double firstNumber, double lastNumber)
{
    double result = 0;
    if (firstNumber < lastNumber)
    {
        result = firstNumber + SumFor(firstNumber + 1, lastNumber);
    }
    else if (firstNumber == lastNumber)
    {
         result = result + lastNumber;
    }
    return result;
}

double m = 2;
double n = 6;
Console.WriteLine($"Сумма натуральных чисел от {m} до {n} = {SumFor(m, n)}");

 }
}
}

