using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(VariantCounter(4, [1, 2]));
        Console.WriteLine(VariantCounter(5, [1, 3, 5]));
        Console.WriteLine(VariantCounter(6, [1, 2, 3, 6]));
    }

    static int VariantCounter(int n, int[] x)
    {
        int sum = 0;

        if (n == 0) return 1;
        else if (n < 0) return 0;

        for (int i = 0; i < x.Length; i++)
        {
            sum += VariantCounter(n - x[i], x);
        }

        return sum;
    }
}
