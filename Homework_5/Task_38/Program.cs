using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha38()
        /* Задача 38: Задайте массив вещественных чисел. 
        Найдите разницу между максимальным и минимальным элементов массива.*/
        {
        int [] array = new int [5];
        int sum = 0;
        
        for (int i = 0; i < array.Length; i ++)
        {
            array[i] = new Random().Next (100,1000);
            Console.WriteLine(array[i] + " " );
            if (i % 2 == 1) sum +=array[i];
        }
        Console.WriteLine ("Сумма элементов, стоящих на нечетных позициях: " + sum);
        }
    Zadacha38();
    #region Fill & Print
    }
}
}
#endregion

