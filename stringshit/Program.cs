namespace stringshit;
using System;
using System.Text;
class Program
{
    public static void con1(String s1)
    {
        s1 = String.Concat(s1, " hello");
    }
    public static void con2(StringBuilder s2)
    {
        s2.Append(" builder");
    }

    public static void Main(String[] args)
    {
        String s1 = "welcome";
        Console.WriteLine(s1.ToUpper());
        Console.WriteLine(s1.ToLower());
        Console.WriteLine(s1.Length);
        con1(s1);
        Console.WriteLine(s1);

        StringBuilder s2 = new StringBuilder("abhijeeth");
        con2(s2);
        Console.WriteLine(s2);
    }
}
