using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

void Zadacha60()
    {
    int m = 5;
    int n = 4;
    int l = 3;
    int[,,] massiv = new int[m, n, l];
    FillArray(massiv);
    PrintArray(massiv);
    }

Zadacha60();

#region Fill & Print
void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

void FillArray(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = count;
                count += 1;
                if (count >= 100) break;
            }
            if (count >= 100) break;
        }
        if (count >= 100) break;
    }
    if (count >= 100) 
        {
            Console.WriteLine("Ошибка");
        }


    }
}
}
}
#endregion
