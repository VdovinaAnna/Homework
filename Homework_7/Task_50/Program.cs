using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int[,] DemensionArray()
{
    int m = 5;
    int n = 4;
    int[,] array = new int[m + 1 , n + 1];
    return array;
}
void PrintArray(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 100);
        }
    }
}
void FindPosition(int[,] arr)
{
    Console.WriteLine("Введите номер позиции строки элемента: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер позиции столбца элемента: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if ((m <= arr.GetLength(0) && m >= 1 && (n <= arr.GetLength(1) && m >= 1)))
    {
        Console.WriteLine($"Элемент равен : {arr[m,n]}");
    }
    else Console.WriteLine("Такого элемента нет!");

}

int[,] massiv = DemensionArray();
FillArray(massiv);
Console.WriteLine();
PrintArray(massiv);
Console.WriteLine();
FindPosition(massiv);

    #region Fill & Print
    }
}
}
#endregion
