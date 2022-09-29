using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha21()
        /* Задача 21. Напишите программу, которая принимает на вход координаты 
        двух точек и находит расстояние между ними в 3D пространстве.*/
        {
        int a_x = 2;
        int a_y = 5;
        int a_z = 7;
        int b_x = 3;
        int b_y = 4;
        int b_z = 5;

        double result = Math.Sqrt(Math.Pow(a_x - b_x, 2) 
        + Math.Pow(a_y - b_y, 2) + Math.Pow(a_z - b_z, 2));
        Console.WriteLine(result);
        }
        Zadacha21();
    }
    #region Fill & Print
    }
}
#endregion