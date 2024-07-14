namespace inherit;
using System;

public class Employer
{
    public string employerName = "abhi";
}

public class Employee : Employer
{
    public string employeName = "anirudh";
}

public class Test
{
    public static void Main(string[] arg)
    {
        Employee e = new Employee();
        Console.WriteLine(e.employeName);
        Console.WriteLine(e.employerName);
    }
}
