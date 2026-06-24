namespace MultiThreadingImplementation
{
    internal class Program
    {
        static void PrintMessage() { 
            Thread.Sleep(1000);
            Console.WriteLine("Hello From New Thread: " +Thread.CurrentThread.Name);
            Thread.Sleep(1000);
        }
        static void Main(string[] args)
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
