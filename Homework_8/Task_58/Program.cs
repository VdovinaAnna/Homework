using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 58: Задайте две матрицы. 
    Напишите программу, которая будет находить произведение двух матриц.*/

void Zadacha58 ()
    {
    Random random = new Random();
    int mFirst = random.Next(4,8);
    int nFirst = random.Next(4,8);
    int mSecond = nFirst;
    int nSecond = random.Next(4,8);
    int[,] FirstMatrix = new int[mFirst, nFirst];
    int[,] SecondMatrix = new int[mSecond, nSecond];
    FillArray(FirstMatrix);
    PrintArray(FirstMatrix);
    Console.WriteLine();
    FillArray(SecondMatrix);
    PrintArray(SecondMatrix);
    Console.WriteLine();

    int [,] result = new int [mFirst, nSecond];

    for (int i = 0; i < mFirst; i++)
    {
        for (int j = 0; j < nSecond; j++)
        {
            for (int k = 0; k < mSecond; k++)
            {
                result [i, j] += FirstMatrix[i, k] * SecondMatrix[k, j];
            }
        }
    }
    PrintArray(result);
    }

Zadacha58 ();

#region Fill & Print
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

    }
}
}
#endregion
