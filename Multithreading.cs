using System;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Main Thread";

        Thread thread1 = new Thread(() => CountDown("Timer #1"));
        Thread thread2 = new Thread(() => CountUp("Timer #2"));

        thread1.Start();
        thread2.Start();
        System.Console.WriteLine(mainThread.Name + " Is complete.");


    }

    public static void CountDown(String name)
    {
        for (int i = 10; i >= 0; i--)
        {
            System.Console.WriteLine($"Timer #1: {i} Seconds.");
            Thread.Sleep(1000);
        }
        System.Console.WriteLine($"Timer #1 is Complete!");
    }
    public static void CountUp(String name)
    {
        for (int i = 0; i <= 10; i++)
        {
            System.Console.WriteLine($"Timer #2: {i} Seconds.");
            Thread.Sleep(1000);
        }
        System.Console.WriteLine($"Timer #2 is Complete!");
    } 
}