namespace MultiThreadingImplementation
{
    internal class Program
    {
        static void PrintMessage() { 
            Thread.Sleep(1000);
            Console.WriteLine("Hello From New Thread: " +Thread.CurrentThread.Name);
            Thread.Sleep(1000);
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, From Main: " +Thread.CurrentThread.Name);

            ThreadStart ts = new ThreadStart(PrintMessage);

            Thread th = new Thread(ts);

            th.Name = "Thread- 1";

            th.Start();

            Console.WriteLine("Main is Executing: " +Thread.CurrentThread.Name);

            Console.WriteLine("Main Ends Here: " + Thread.CurrentThread.Name);
        }
    }
}
namespace MultiThreadingImplDemo2 {
    internal class Program {
        static void PrintMessage() {
            for (int i = 0; i < 10; i++)
            {
                   Console.WriteLine(" I: " + i + " " + Thread.CurrentThread.Name);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args) {
            Console.WriteLine("Hello, From Main: "+ Thread.CurrentThread.Name);

            ThreadStart ts = new ThreadStart(PrintMessage);

            Thread th1 = new Thread(ts);

            th1.Name = "Thread-1";

            th1.Start();

            for (int i = 0; i < 10; i++) {
                Console.WriteLine(" I: " + i + " " + Thread.CurrentThread.Name);
            }

            Console.WriteLine("Main is Executing: " + Thread.CurrentThread.Name);


            Console.WriteLine("Main Ends Here: " + Thread.CurrentThread.Name);
        }
    }
}
