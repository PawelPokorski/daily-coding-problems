using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] array = {-3,2,-1,1,7,2,3,4,5,6};
        
        Console.WriteLine(FirstMissingPositive(array));
    }
    
    public static int FirstMissingPositive(int[] nums)
    {
        HashSet<int> seenNumbers = new();
        
        foreach(int num in nums)
        {
            if(num > 0)
                seenNumbers.Add(num);
        }
        
        for(int i = 1; i <= nums.Length; i++)
        {
            if(!seenNumbers.Contains(i))
                return i;
        }
        
        return nums.Length + 1;
    }
}
