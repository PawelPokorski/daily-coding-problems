using System;

public class Program
{
    static void Main(string[] args)
    {
        string[] set = ["deer", "deal", "dog", "demon", "older", "detective", "driver", "bird", "golden"];

        var output = Search("de", set);

        foreach (var o in output)
        {
            Console.Write(o + ", ");
        }
    }

    static string[] Search(string query, string[] set)
    {
        return [.. set.Where(p => p.StartsWith(query))];
    }
}
