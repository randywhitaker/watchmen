using System;
using System.Threading;

namespace watchmen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread thr = new Thread(job1);
            thr.Start();

            Console.WriteLine("Main job completed!");
            Console.ReadLine();
        }
        static void job1()
        {
            int counter = 0;
            do
            {
                counter++;
                Console.WriteLine("My Job is running");
            } while(counter < 5);
        }
    }
}
