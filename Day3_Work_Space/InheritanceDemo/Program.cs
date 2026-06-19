namespace InheritanceDemo
{

    class Shape
    {
        public double area;
        public double perimeter;

        public void PrintArea()
        {
            Console.WriteLine("Area : " + this.area);
        }
        public void PrintPerimeter()
        {
            Console.WriteLine("Perimeter : " + this.perimeter);
        }
        public virtual void CalculateArea()
        {
            Console.WriteLine("Area of shape");
        }
    }

    class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                this.radius = value;
            }
        }

        public override void CalculateArea()
        {
            this.area = Math.PI * this.radius * this.radius;
        }
    }

    class Rectangle : Shape
    {
        public double length;
        public double width;

        public new void CalculateArea()
        {
            this.area += this.length * this.width;
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            //Circle c1 = new Circle();
            //c1.Radius = 10;
            //c1.CalculateArea();
            //c1.PrintArea();

            Circle c1 = new Circle() { Radius = 10};
            c1.CalculateArea();
            c1.PrintArea();

            Shape shape = new Shape();
            shape.CalculateArea();
            shape.PrintArea();
        }
    }
}

namespace NewKeyWordDemo {
    class Shape {
        public double area;
        public double perimeter;

        public void PrintArea() {
            Console.WriteLine("Area : " + this.area);
        }

        public void PrintPerimeter()
        {
            Console.WriteLine("Perimeter : " + this.perimeter);
        }
        public new void CalculateArea() {
            Console.WriteLine("Area of shape");
        }
    }

    class Circle : Shape { 
        private double radius;
        
        public double Radius { 
            get { return this.radius; } set { this.radius = value; }
        }
        public new void CalculateArea() { 

            this.area = Math.PI * this.radius * this.radius;
        }
    }

    class Rectangle : Shape {
        public double length;
        public double width;

        public new void CalculateArea() { 
            this.area = this.length * this.width;
        }
    }

    internal class  Program
    {
        public static void Main(string[] args) { 
            Rectangle r1 = new Rectangle() { length = 10, width = 20};
            r1.CalculateArea();
            r1.PrintArea();
        }
        
    }

}