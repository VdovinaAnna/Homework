Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int m = 1;
int i = m;
while(i <= N)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
            i = i+1;
        }
