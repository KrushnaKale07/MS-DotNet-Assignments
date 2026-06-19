namespace InterfacesDemo
{

    interface IMyInterface {
        void Show();
    }

    class Test : IMyInterface {
        public void Show() {
            Console.WriteLine("Hello From Test");
        }
    }

    interface IShape {
        public void CalculateArea();
        public void PrintArea();
        public void PrintPerimeter();
    }

    class Shape : IShape { 
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public void CalculateArea() { 
        
        }

        public void PrintArea() {
            Console.WriteLine("Area " + this.Area);
        }
        public void PrintPerimeter() { 
            Console.WriteLine("Perimeter: "+this.Perimeter);
        }
    }

    class Circle : Shape { 
        public double Radius { get; set; }
        public void CalculateArea() {
            this.Area = Math.PI * this.Radius * this.Radius;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.Radius = 23;
            c1.CalculateArea();
            c1.PrintArea();
        }
    }
}
