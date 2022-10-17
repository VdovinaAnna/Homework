using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
    { /*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.*/

void Zadacha62 ()
    {
    int Row = 4;
    int Columns = 4;
    int[,] massiv = new int[Row, Columns];

    int index = 0;
    int currentRow = 0;
    int currentColumn = 0;

    int changeIndexRow = 0;
    int changeIndexColumn = 1;

    int steps = Columns;
    int turn = 0;

    while (index < massiv.Length)
    {
        massiv[currentRow, currentColumn] = index + 1;
        index++;
        steps--;
        if (steps == 0)
        {
            steps = Columns - 1 - turn/2;
            int temp = changeIndexRow;
            changeIndexRow = changeIndexColumn;
            changeIndexColumn = -temp;
            turn++;

        }

        currentRow += changeIndexRow;
        currentColumn += changeIndexColumn;
    }
    PrintArray(massiv);
    }

Zadacha62 ();
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
