using System.Diagnostics.CodeAnalysis;

namespace OperatorOverloading
{
    class TestOne { 
        public int x ; 
        public int y;

        public TestOne() {
            this.x = 0;
            this.y = 0;
        }

        public TestOne(int x, int y) { 
            this.x = x;
            this.y = y; 
        }

        public void Print() {
            Console.WriteLine(" X: " + this.x + " Y: " + this.y);
        }
        public static TestOne operator +(TestOne o1, TestOne o2)
        {
            return new TestOne(o1.x + o2.x, o1.y + o2.y);
        }
        public static TestOne operator -(TestOne o1, TestOne o2) { 
            TestOne temp = new TestOne();

            temp.x = o1.x - o2.x;
            temp.y = o1.y - o2.y;
            return temp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 100;
            TestOne t1 = new TestOne(10,20);
            TestOne t2 = new TestOne(30,80);
            
            TestOne t3 = t1 - t2;
            t3.Print();

            TestOne t4 = t1 + t2; 
            t3.Print();

        }
    }
}
