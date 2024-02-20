//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
/*void FuncAnkerman(int n, int m )
{
    if (m = 0)
    {
        Console.WriteLine(n + 1);
        return;
    }
    if (m = 1)
    {
        Console.WriteLine(n + 3);
        return;
    }
    if (m = 2)
    {
        Console.WriteLine(2n + 3);
        return;
    }
    if (m = 3)
    {
        double result = Math.Pow(2, n + 3) - 3;
        Console.WriteLine(result);
        return;
    }
   
    RangeOfDigit(n + 1, m);
    Console.WriteLine(n);
}
//int n = 1;
RangeOfDigit(1, 14);*/
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        //Console.WriteLine($"if m=0, вернули n + 1");
        return n + 1;
    }
    else if (n == 0)
    {
        //Console.WriteLine($"if m!=0 n=0, вернули Ackermann(m - 1, 1)");
        return Ackermann(m - 1, 1);
    }
    else
    {
        //Console.WriteLine($"if m!=0 n!=0, вернули Ackermann(m, n-1)");
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

void Main()
{
    int m = 3;
    int n = 3;
    int result = Ackermann(m, n);
    Console.WriteLine($"Ackermann({m}, {n}) = {result}");
}
Main();