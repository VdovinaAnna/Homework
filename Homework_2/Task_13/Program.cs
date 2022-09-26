using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha13()
        /* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
        или сообщает, что третьей цифры нет.*/
        {
        int number = 264886;
        number = Math.Abs(number);

        if (number > 99)
        {
            while(number > 999)
            {
            number /= 10;
            }
            Console.WriteLine("Третья цифра " + number%10);
        }
        else
        {
            Console.WriteLine("Третьей цифры нет");
        }
        }
        Zadacha13();
    }
    #region Fill & Print
    }
}
#endregion