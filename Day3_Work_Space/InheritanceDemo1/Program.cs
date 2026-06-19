namespace InheritanceDemo {

    class Shape {
        public double area;
        public double perimeter;

        public void PrintArea() { 
            Console.WriteLine("Area : "+ this.area);
        }
        public void PrintPerimeter() {
            Console.WriteLine("Perimeter : " + this.perimeter);
        }
        public void CalculateArea()
        {
            Console.WriteLine("Area of shape");
        }        
    }

    class Circle : Shape {
        private double radius;

        public double Radius {
            get { 
                return this.radius; 
            }
            set { 
                this.radius = value;
            }
        }

        public override void CalculateArea() { 
            this.area = Math.PI * this.radius * this.radius;
        }
    }

    class Rectangle : Shape {
        public double length;
        public double width;

        public new void CalculateArea() {
            this.area += this.length * this.width;
        }
    }
    internal class Program
    {
        static void Main(string[] args) { 
            Circle c1 = new Circle();
            c1.Radius = 10;
            c1.CalculateArea();
            c1.PrintArea();
        }
    }
}