using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha43()
        /* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
        заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
        значения b1, k1, b2 и k2 задаются пользователем.*/
    {
    double GetNumber(string name)
    {
        Console.WriteLine("Введите значение " + name + "");
        return Convert.ToDouble(Console.ReadLine());
    }

    double k1 = GetNumber("k1");
    double b1 = GetNumber("b1");
    double k2 = GetNumber("k2");
    double b2 = GetNumber("b2");
    

    if (k1 == k2)
    {
        Console.WriteLine("Нет пересечения прямых");
    }
    else
    {
    double x = Convert.ToDouble(b2 - b1)/Convert.ToDouble(k1 - k2);
    x = Math.Round(x,2);
    double y = k1 * x + b1;
    y = Math.Round(y,2);
    Console.WriteLine($"Точка пересечения {x}, {y} ");
    };
    #region Fill & Print
    }
Zadacha43();
}
}
}
#endregion

