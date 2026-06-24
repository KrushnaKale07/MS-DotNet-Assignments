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
        static void Main(string[] args)
        {
            Test test = new Test();
            Thread thread1 = new Thread(new ParameterizedThreadStart(test.GenTable));
            Thread thread2 = new Thread(new ParameterizedThreadStart(test.GenTable));
            
            thread1.Start(10);
            thread2.Start(20);
                
        }

    }
}
