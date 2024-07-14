namespace overload;
using System;

class Program
{
    public int add(int a, int b, int c)
    {
        return a + b + c;
    }
    public int add(int a)
    {
        return a;
    }
    public int add(int a, int b)
    {
        return a + b;
    }
    static void Main(string[] args)
    {
        Program cal = new Program();
        Console.WriteLine(cal.add(1, 2));
        Console.WriteLine(cal.add(1, 2, 3));
        Console.WriteLine(cal.add(1));

    }
}
