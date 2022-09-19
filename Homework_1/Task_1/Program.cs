Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
int min = a, max = b;
if(a==b)
{
 Console.WriteLine ("Числа равны");
}
else
{
    if (a < b)
    {
    min = a; 
    max = b;
    Console.WriteLine ("min = " + min);
    Console.WriteLine ("max = " + max);
    }
    else
    {
    min = b;
    max = a;
    Console.WriteLine ("min = " + min);
    Console.WriteLine ("max = " + max);
    }
}