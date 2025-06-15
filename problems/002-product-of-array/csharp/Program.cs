using System;
using System.Linq;

public class Program
{
    static int[] numbers = [1, 2, 3, 4, 5];

    static void Main(string[] args)
    {
        var output = ArrayProduct(numbers);
        Console.WriteLine(string.Join(", ", output));
    }

    static int[] ArrayProduct(int[] array)
    {
        int length = array.Length;
        int[] productArray = [.. Enumerable.Repeat(1, length)];

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                if (i != j)
                    productArray[i] *= array[j];
            }
        }

        return productArray;
    }
}
