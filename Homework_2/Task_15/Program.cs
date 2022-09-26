using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha15()
        /* Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
        и проверяет, является ли этот день выходным.*/
        {
        int day = 7;

        if (day >0 && day < 8)
        {
            if (day == 6 || day == 7)
            {
            Console.WriteLine("Выходной день");
            }
            else
            {
            Console.WriteLine("Будний день");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод");
        }
        }
        Zadacha15();
    }
    #region Fill & Print
    }
}
#endregion