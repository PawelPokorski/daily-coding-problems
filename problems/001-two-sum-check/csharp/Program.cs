using System;
using System.Collections.Generic;

public class Program
{
    static int[] numbers = [10, 15, 3, 7];

    static void Main(string[] args)
    {
        Console.Write("Enter the number k: ");

        if (int.TryParse(Console.ReadLine(), out int k))
            Console.WriteLine(CheckSum(k));
        else
            Console.WriteLine("Invalid input.");
    }

    static bool CheckSum(int k)
    {
        HashSet<int> seenNumbers = [];

        foreach (int number in numbers)
        {
            int complement = k - number;
            if (seenNumbers.Contains(complement))
                return true;

            seenNumbers.Add(number);
        }

        return false;
    }
}
