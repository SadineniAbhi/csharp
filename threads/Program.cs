namespace threads;
using System;
using System.Threading;

class ThreadingExample
{
    public void example()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("first thread");
        }
    }
}

class Test
{
    public static void Main(String[] a)
    {
        ThreadingExample obj = new ThreadingExample();
        Thread t = new Thread(new ThreadStart(obj.example));
        t.Start();

        //to delete or abort an thread
        //t.Abort();
    }
}
