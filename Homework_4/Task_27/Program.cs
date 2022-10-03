using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha27()
        /* Напишите программу, которая принимает на вход число 
        и выдаёт сумму цифр в числе.*/
        {
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (a > 0)
        {
            sum += a%10;
            a /= 10;
        }
        Console.WriteLine($"Сумма цифр числа равна {sum}");
        }
    Zadacha27();
    #region Fill & Print
    }
}
}
#endregion
