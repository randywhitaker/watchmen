using System;
using System.Threading;

namespace watchmen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread jobA = new Thread(Gateway1);
            Thread jobB = new Thread(Gateway2);
            Thread jobC = new Thread(Gateway3);

            jobC.Start();
            jobB.Start();
            jobA.Start();

            jobA.Join();
            jobB.Join();
            jobC.Join();

            Console.WriteLine("Main job completed!");
            //Console.ReadLine();
        }
        static void Gateway1()
        {
            int counter = 0;

            try
            {
                do
                {
                    counter++;
                    Console.WriteLine("Waitting on SMS message 1");
                    Thread.Sleep(978);

                    if (counter >= 5)
                        throw new Exception("Bad message");

                } while(counter < 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("SMS 1 Completed");
        }
        static void Gateway2()
        {
            int counter = 0;

            try
            {
                do
                {
                    counter++;
                    Console.WriteLine("Waitting on SMS message 2");
                    Thread.Sleep(6000);

                    if (counter > 3)
                        throw new Exception("connection failed");

                } while(counter < 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("SMS 2 Completed");
        }
        static void Gateway3()
        {
            int counter = 0;

            try
            {
                do
                {
                    counter++;
                    Console.WriteLine("Waitting on SMS message 3");
                    Thread.Sleep(8000);

                    if (counter >= 5)
                        throw new Exception("message failed");

                } while(counter < 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("SMS 3 Completed");
        }
    }
}
