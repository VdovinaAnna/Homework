using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    {
        void Zadacha41()
        /* Задача 41: Пользователь вводит с клавиатуры M чисел. 
        Посчитайте, сколько чисел больше 0 ввёл пользователь.*/
        {
        Console.WriteLine ("Сколько чисел будете вводить? ");
        int countNumbers = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = 1; i <= countNumbers; i++)
        {
            Console.WriteLine($"Введите {i} число ");
            int inputNamber = Convert.ToInt32(Console.ReadLine());
            if (inputNamber > 0) count++;
        }
        Console.WriteLine ("Чисел больше 0: " + count);
        }
    Zadacha41();
    #region Fill & Print
    }
}
}
#endregion

