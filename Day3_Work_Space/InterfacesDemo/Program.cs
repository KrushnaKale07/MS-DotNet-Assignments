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
        static void Main1(string[] args)
        {
            Circle c1 = new Circle();
            c1.Radius = 23;
            c1.CalculateArea();
            c1.PrintArea();
        }
    }
}

namespace InterfaceDemo2 {

    interface IEmployeeAdmin {
        void Add();
        void Update();
        void Delete();
        void GetAll();

    }

    class Employee { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Salary { get; set; }
    }

    class EmployeeAdmin : IEmployeeAdmin { 
        List<Employee> eList = new List<Employee>();
        public EmployeeAdmin() { 
            eList.Add(new Employee() {Id = 101, Name = "Krushna", Age = 26, Salary = 50000.00f});
        }

        public void Add() { 
            Employee e = new Employee();
            Console.WriteLine("Enter Roll No :");
            e.Id = Console.Read();

            eList.Add(e);
        }

        public void Delete() { 
            throw new NotImplementedException();
        }

        public void GetAll() { 
            throw new NotSupportedException();
        }
        public void Update() {
            throw new NotImplementedException();
        }
    }
}

namespace InterfaceDemo3 {
    interface IMyInterface {
        void Display();
    }

    class TestOne : IMyInterface {
        void IMyInterface.Display()
        {
            Console.WriteLine("Hello from display");
        }
    }

    internal class  Program
    {
        public static void Main() { 
            IMyInterface t1 = new TestOne();
            t1.Display();
        }   
    }
}
