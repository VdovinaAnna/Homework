using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha34()
        /* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
        Напишите программу, которая покажет количество чётных чисел в массиве.*/
        {
        int [] array = new int [8];
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next (10,100);
            Console.Write(array[i] + " ");
            if (array[i] % 2 == 0) count++;
        }
        Console.WriteLine(" Количество четных элементов: " +count);
        }
    Zadacha34();
    #region Fill & Print
    }
}
}
#endregion
