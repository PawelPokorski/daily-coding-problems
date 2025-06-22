using System;

namespace Common;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(NonAdjacentSum([2, 4, 6, 2, 5]));
        Console.WriteLine(NonAdjacentSum([5, 1, 1, 5]));
        Console.WriteLine(NonAdjacentSum([1, -2, 3, -4]));
        Console.WriteLine(NonAdjacentSum([-1, -2, -3, -4]));
        Console.WriteLine(NonAdjacentSum([5]));
        Console.WriteLine(NonAdjacentSum([]));
        Console.WriteLine(NonAdjacentSum([9,1,10,8,20,10]));
        Console.WriteLine(NonAdjacentSum([3,4,9,6,1]));
    }

    static int NonAdjacentSum(int[] input)
    {
        int n = input.Length;

        if (n == 0)
            return 0;
        else if (n == 1)
            return Math.Max(0, input[0]);

        
        int sum0 = input[0] > 0 ? input[0] : 0;
        int sum1 = input[1] > 0 ? input[1] : 0;
        int prev0 = sum0;
        int prev1 = sum1;


        for (int i = 0; i < n; i++)
        {
            if (i == 2)
            {
                sum0 = Math.Max(sum0, Math.Max(input[i] + sum0, input[i] + prev0));
            }
            else
            {
                if (i % 2 == 0)
                {
                    sum0 = Math.Max(input[i] + sum0, Math.Max(input[i] + prev0, input[i] + prev1));
                }
                else
                {
                    sum1 = Math.Max(input[i] + sum1, Math.Max(input[i] + prev0, input[i] + prev1));
                }

                prev0 = sum0;
                prev1 = sum1;
            }
        }

        return Math.Max(sum0, sum1);
    }
}
