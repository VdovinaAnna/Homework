using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha19()
        /* Задача 19. Напишите программу, которая принимает на вход пятизначное число
         и проверяет, является ли оно палиндромом.*/
        {
        Console.WriteLine("Введите пятизначное число");
        int number = Convert.ToInt32(Console.ReadLine());
        int CurrentNumber = number;
        int result = 0;
        while (CurrentNumber > 0)
        {
            int digit = CurrentNumber % 10;
            result = result * 10 + digit;
            CurrentNumber /= 10;
        }
        if (number == result)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
        }
        Zadacha19();
    }
    #region Fill & Print
    }
}
#endregion