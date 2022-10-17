using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
    элементы каждой строки двумерного массива.*/


int[,] GetDemension()
{
    int m = 5;
    int n = 4;
    int[,] array = new int[m, n];
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void ArrangeArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
                }
            }
        }
    }
}

int[,] massiv = GetDemension();
FillArray(massiv);
PrintArray(massiv);
ArrangeArray(massiv);
PrintArray(massiv);

    #region Fill & Print
    }
}
}
#endregion
