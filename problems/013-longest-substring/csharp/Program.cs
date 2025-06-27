using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LongestSubstring("abcba", 2)); // bcb
        Console.WriteLine(LongestSubstring("abcba", 3)); // abcba
        Console.WriteLine(LongestSubstring("abcbababa", 2)); // bababa
        Console.WriteLine(LongestSubstring("ccbbabbcc", 2)); // bbabb
    }

    static string LongestSubstring(string s, int k)
    {
        if (string.IsNullOrEmpty(s) || k <= 0)
            return string.Empty;

        HashSet<char> distinctChars = [];

        int firstIndex = 0, lastIndex = 0; // pointers
        int bestFirstIndex = 0; // first index of longest substring
        int maxLength = 0; // length of longest substring

        // if lastIndex reach s.Length, that means that last checked substring was the longest or algorithm checked all possible substrings
        while (lastIndex < s.Length)
        {
            distinctChars.Add(s[lastIndex]);

            if (distinctChars.Count > k)
            {
                firstIndex++;
                lastIndex = firstIndex;
                distinctChars.Clear();
            }
            else
                lastIndex++;

            int length = lastIndex - firstIndex;

            if (length > maxLength)
            {
                maxLength = length;
                bestFirstIndex = firstIndex;
            }
        }
        
        return s.Substring(bestFirstIndex, maxLength);
    }
}
