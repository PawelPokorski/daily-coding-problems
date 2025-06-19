using System;

class Program
{
    public delegate object Pair(Func<object, object, object> f);

    public static Pair Cons(object a, object b)
    {
        Pair pair = f => f(a, b);
        return pair;
    }

    public static object Car(Pair pair)
    {
        return pair((a, b) => a);
    }

    public static object Cdr(Pair pair)
    {
        return pair((a, b) => b);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Car(Cons(3, 4)));
        Console.WriteLine(Cdr(Cons(3, 4)));
        Console.WriteLine(Cdr(Cons(3, "string")));
        Console.WriteLine(Car((Pair)Cdr(Cons("first", Cons("second", "third")))));
    }
}
