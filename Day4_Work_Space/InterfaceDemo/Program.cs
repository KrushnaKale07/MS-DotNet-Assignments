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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
