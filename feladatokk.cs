// Abs max
void abs_max(int a, int b)
{
    Math.Abs(a);
    Math.Abs(b);
    Console.WriteLine($"Return: {Math.Max(a, b)} ");
}

abs_max(12, 15);

// Fibonacci

void fibo(int a, int b)
{
    static long fibo(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
            return a;
        }
        return b;
    }
}

fibo(12, 5);