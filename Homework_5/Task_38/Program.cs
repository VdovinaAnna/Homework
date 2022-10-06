using System;

namespace Project
{
    class Programm
    {
    static void Main(string[] args)
{ /* Задача 38: Задайте массив вещественных чисел. 
        Найдите разницу между максимальным и минимальным элементов массива.*/

void FillArray(double[] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Math.Round (random.NextDouble() * 20 - 10, 2);
        } 
}

void PrintArray(double[] arr)
    {
    int size = arr.Length;
    Console.WriteLine("Вывод массива: ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}    

double MaxElement (double[] array)
{
    double maxElement = array[0]; 
    for (int i = 1; i < array.Length; i++) 
    {
        if (array[i] > maxElement) 
        {
            maxElement = array[i]; 
        }
    }
    return maxElement;
}

double MinElement (double[] array)
{
    double minElement = array[0]; 
    for (int i = 1; i < array.Length; i++) 
    {
        if (array[i] < minElement) 
        {
            minElement = array[i]; 
        }
    }
    return minElement;
}

double GetDiffMaxMin (double[] array, double maxElement, double minElement) 
{
    double diff = Math.Round((maxElement - minElement), 2); 
    return diff;
}

double[] arr = new double[8];
FillArray(arr);
PrintArray(arr);
double maxElement = MaxElement(arr);
Console.WriteLine("Максимальный элемент: " + maxElement + ".");
double minElement = MinElement(arr);
Console.WriteLine("Минимальный элемент: " + minElement + ".");
Console.WriteLine("Разница между числами: " + GetDiffMaxMin(arr, maxElement, minElement) + ".");
    #region Fill & Print
    }
}
}
#endregion

