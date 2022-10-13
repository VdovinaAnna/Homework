using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 52. Задайте двумерный массив из целых чисел. 
    Найдите среднее арифметическое элементов в каждом столбце.*/

int[,] DemensionArray()
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
}
void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}

void ArithmeticMean(int[,] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum = sum + arr[j, i];
            if (j == (arr.GetLength(0) - 1))
            {
                Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно {Math.Round(sum / (j + 1), 1)}");
                sum = 0;
            }
        }
    }
}

int[,] massiv = DemensionArray();
FillArray(massiv);
Console.WriteLine();
PrintArray(massiv);
Console.WriteLine();
ArithmeticMean(massiv);

    #region Fill & Print
    }
}
}
#endregion