namespace InterfaceDemo
{

    interface IShape {
        void CalculateArea();
        void CalculatePeri() {
            Console.WriteLine("Default Method");
        }
    }

    abstract class Shape { 
        public double Area { get; set; }
        public void PrintArea() { 
            Console.WriteLine("Ares : " + this.Area);
        }

        public abstract void CalArea();
    }

    class Circle : IShape {
        public void CalculateArea() { 
        
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
namespace InterfaceInheritance
{
    interface MyInterface1
    {
        void Method1();
        void Method2();
    }
    interface MyInterface2
    {
        void Method2();

    }

    interface MyInterface3 : MyInterface1, MyInterface2     //Multiple Inheritance
    {
        void Method3();
    }

    class TestOne : MyInterface3
    {
        public void Method1()
        {
            Console.WriteLine("Method1 of Interface1 by Test One");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 of Interface2 by Test One");
        }

        void MyInterface1.Method2()
        {
            Console.WriteLine("Method2 of Interface1 by Test One");
        }

        public void Method3()
        {
            Console.WriteLine("Method3 of Interface3 by Test One");
        }
    }

    internal class TestInterfaces
    {
        static void Main1()
        {
            TestOne t1 = new TestOne();

            t1.Method1();
            t1.Method2();
            t1.Method3();

            MyInterface1 mt = new TestOne();
            mt.Method2();
        }
    }
}
namespace DestructorDemo {
    class TestOne
    {
        public int Num1;

        public TestOne()
        {
            this.Num1 = 1;
            Console.WriteLine("Cons of Testone");
        }

        ~TestOne()
        {
            Console.WriteLine("Destructor Called");
        }
    }

    internal class TestOneDemo
    {
        static void Main()
        {
            TestOne t1 = new TestOne();

            Console.WriteLine("Num1: " + t1.Num1);
        }
    }
}
