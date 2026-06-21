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
        static void Main1(string[] args)
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
namespace StructDemo
{
    struct Employee {
        public int Id;
        public string Name;
        public float Salary;

        public void Print() {  
            Console.WriteLine("Id: " + this.Id + " Name : "+ this.Name + " Salary : "+ this.Salary);
        }
    }

    internal class TestStruct { 

        static void Main1() { 

        Employee e1 = new Employee();
        e1.Id = 1;
        e1.Name = "Krushna";
        e1.Salary = 700000.56f;

            e1.Print();
        }

    }
}
namespace OutAndRef {

    internal class TestOne {
        public static void Update(ref int x)
        {
            x = x = 1;
        }

        public static void UpdateValues(int x, int y, out int sum, out int product) {
            sum = x + y;
            product = x*y;
        
        }

        static void Main1() { 
            int sum, product;
            int num1 = 10, Num2 = 5;
            UpdateValues(num1, Num2, out sum, out product);
            Console.WriteLine("Sum of Num1 and Num2 : " + sum);
            Console.WriteLine("Mul of Num1 and Num2 : " + product);
        }

        static void Main()
        {
            int Num1 = 100;
            Console.WriteLine("Num1 before calling Update: " + Num1);

            Update(ref Num1);

            Console.WriteLine("Num1 after calling Update: " + Num1);
        }
    }
   
}
