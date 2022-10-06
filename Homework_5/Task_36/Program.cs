using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha36()
        /* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        Найдите сумму элементов, стоящих на нечётных позициях.*/
        {
        int [] array = new int [5];
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next (100,1000);
            Console.WriteLine(array[i] + " " );
            if (i % 2 == 1) sum +=array[i];
        }
        Console.WriteLine ("Сумма элементов, стоящих на нечетных позициях: " + sum);
        }
    Zadacha36();
    #region Fill & Print
    }
}
}
#endregion

