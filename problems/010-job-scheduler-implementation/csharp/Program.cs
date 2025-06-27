using System;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Schedule(() => { Console.WriteLine(DateTime.Now); }, 2000);

        Console.ReadKey();
    }

    public static async void Schedule(Action f, int n)
    {
        await Task.Delay(n);

        f();
    }
}
