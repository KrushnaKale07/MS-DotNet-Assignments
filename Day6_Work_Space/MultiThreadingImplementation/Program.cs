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
        static void Main1(string[] args) {
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
namespace MultiThreadingImplDemo3 {
    internal class Program {
        static void PrintMessage(Object str) {
            //string name = str.ToString();

            int number = (int)str;

            for (int i =0; i < 10; i++) {
                Console.WriteLine(number + Thread.CurrentThread.Name);
                Thread.Sleep(500);
            }
        }

        static void Main1(string[] args) {
            Console.WriteLine("Hello, From Main: "+ Thread.CurrentThread.Name);

            ParameterizedThreadStart pts = new ParameterizedThreadStart(PrintMessage);

            Thread th1 = new Thread(pts);

            th1.Name = "Thread-1";

            th1.Start(1000);

            for (int i = 0; i < 10; i++) {
                Console.WriteLine(" I: " + i + " " + Thread.CurrentThread.Name);
            }

            Console.WriteLine("Main is Executing: " + Thread.CurrentThread.Name);


            Console.WriteLine("Main Ends Here: " + Thread.CurrentThread.Name);
        }
    }
}
namespace MultiThreadingImplDemo4
{
    internal class Program {
        static void PrintMessage(Object str) {
            int number = (int)str;
            Console.WriteLine("Executed By: "+ Thread.CurrentThread.Name);
            //Thread.Sleep(1000);
        }

        static void Main(string[] args) {
            for (int i = 0; i < 5; i++) {
                ThreadPool.QueueUserWorkItem(PrintMessage, i);
            }
            Console.WriteLine("Main Ends here");
        }
    }
}
