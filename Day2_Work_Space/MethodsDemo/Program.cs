using System.Collections;

namespace MethodsDemo
{

    class Student { }
    internal class Program
    {

        public static void Add(int a, int b) { 
            int sum = a + b;
            Console.WriteLine("Sum: " + sum);
        }

        public static int Add(int a, int b, int c)
        {
            return  a + b + c;
            
        }
        static void Main1(string[] args)
        {
            int a = 10;
            ArrayList a1 = new ArrayList();
            Student s1 = new Student();

            Add(10, 30);

            int sum = Add(10,20,30);
            Console.WriteLine("Sum of three: " + sum);
        }
    }
}
