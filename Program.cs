//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

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