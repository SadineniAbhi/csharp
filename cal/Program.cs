namespace cal;
using System;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int temporg = n;
        int temp = 0;
        while (n > 0)
        {
            temp = (10 * temp) + n % 10;
            n = n / 10;
        }

        if (temporg == temp)
        {
            Console.WriteLine("It is an palindrome");
        }
        else
        {
            Console.WriteLine("Not an plaindrome");
        }
    }
}
