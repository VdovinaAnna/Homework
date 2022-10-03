using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha29()
        /* Задача 29: Напишите программу, которая задаёт массив 
        из 8 элементов и выводит их на экран.*/
        {
        int [] array = new int [8];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next (0,10);
            Console.Write(array[i] + " ");
        }
        }
    Zadacha29();
    #region Fill & Print
    }
}
}
#endregion
