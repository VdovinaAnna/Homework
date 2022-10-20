using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
    в промежутке от N до 1. Выполнить с помощью рекурсии.*/

    int number = 10;
    Zadacha64(number);
    void Zadacha64 (int number, int count = 0)
    {
        if (number > 1)
    {
        Console.Write($"{number}, ");
        Zadacha64(number - 1);
    }
    else if (number == 1)
    {
        Console.Write(number);
        Console.WriteLine();
    }
    }
 }
}
}

