using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha25()
        /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
        и возводит число A в натуральную степень B.*/
        {
        Console.WriteLine("Введите число 1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число 2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for (int i =1; i <= b; i++)
        {
            result *= a;
        }
        Console.WriteLine($"Число {a} в степени {b} равно {result}");

        }
        Zadacha25();
    }
    #region Fill & Print
    }
}
#endregion