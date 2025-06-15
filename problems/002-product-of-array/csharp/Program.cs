
using System;
using System.Linq;

public class Program
{
    static int[] numbers = [1, 2, 3, 4, 5];

    static void Main(string[] args)
    {
        var output = ArrayProduct(numbers);

        foreach (var o in output)
        {
            Console.Write($"{o} ");
        }
    }

    static int[] ArrayProduct(int[] array)
    {
        int[] productArray = [.. Enumerable.Repeat(1, array.Length)];

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (i != j)
                    productArray[i] *= array[j];
            }
        }

        return productArray;
    }
}
