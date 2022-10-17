using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 56: Задайте прямоугольный двумерный массив. 
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

void Zadacha56 ()
    {
    int m = 5;
    int n = 4;
    int[,] massiv = new int[m, n];
    FillArray(massiv);
    PrintArray(massiv);
    int sumMin = SumInRow(massiv, 0);
    int indexMin = 0;

    for (int j = 0; j < n; j++)
    {
        sumMin += massiv [0, j];
    }

    for (int i = 1; i < m; i++)
    {
        int sum = SumInRow(massiv, i);
        if(sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма равна {sumMin}  и находится в строке {indexMin + 1}");
    }
Zadacha56 ();

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

int SumInRow(int[,] arr, int i)
{
        int n = arr.GetLength(1);
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки равна {sum}");
        return sum;
}
    }
}
}
#endregion
