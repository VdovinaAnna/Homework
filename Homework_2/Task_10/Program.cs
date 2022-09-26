using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha10()
        /* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
        и на выходе показывает вторую цифру этого*/
        {
        Console.WriteLine("Введите трехзначное число");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 99 && number < 1000)
        {
            Console.WriteLine("Вторая цифра числа " + (number/10%10));
        }
        else
        {
            Console.WriteLine("Введено не трехзначное число");
        }
        }
        Zadacha10();
    }
    #region Fill & Print
    }
}
#endregion