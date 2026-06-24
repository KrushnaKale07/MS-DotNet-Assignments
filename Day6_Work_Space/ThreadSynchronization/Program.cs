namespace ThreadSynchronization
{
    public class Test { 
        public void GenTable(Object obj) { 
            int num1 =(int)obj;

            for (int i = 1; i <= 10; i++) { 
                Console.WriteLine($"{num1} * {i} = {num1*i}");
                Thread.Sleep(1000);
            }
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Test test = new Test();
            Thread thread1 = new Thread(new ParameterizedThreadStart(test.GenTable));
            Thread thread2 = new Thread(new ParameterizedThreadStart(test.GenTable));
            
            thread1.Start(10);
            thread2.Start(20);
                
        }

    }
}
namespace ThreadSynchronization1 {
    public class Test { 
        private static object  locker = new object();

        public void GenTable(Object obj)
        { 
            int num1 =(int)obj;

            lock (locker) {
                for (int i = 1; i <= 10; i++) { 
                    Console.WriteLine($"{num1} * {i} = {num1 * i}");
                    Thread.Sleep(1000);
                }
            }
        }
    }

    internal class Program
    {

        static void Main(string[] args) {
            Test t1 = new Test();       //Shared Resources


            // ParameterizedThreadStart pts=new ParameterizedThreadStart(t1.GenTable);

            Thread th1 = new Thread(new ParameterizedThreadStart(t1.GenTable));
            Thread th2 = new Thread(new ParameterizedThreadStart(t1.GenTable));

            th1.Start(10);
            th2.Start(20);
        }
    }
}
