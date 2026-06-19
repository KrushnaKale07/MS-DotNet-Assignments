namespace StaticDemo
{

    class Employee {
        private int id;
        private string name;
        private float salary;
        private static string companyName;

        public Employee() {
            this.id = 0;
            this.name = "";
            this.salary = 0.0f;
        }

        static Employee() {
            Employee.companyName = "C-Dac Mumbai";
        }

        public static string CompanyName
        {
            get {
                return companyName;
            }
            set {
                Employee.companyName = value;
            }
        }

        public float Salary {
            get {
                return this.salary;
            }
            set {
                this.salary = value;
            }
        }

        public int Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }

        public string Name {
            get {
                return name;
            }
            set {
                this.name = value;
            }
        }

        public void Show() {
            Console.WriteLine("Id : " + this.id + " Name : "+ this.name + " Salary : "+ this.salary);
        }

        public static void Display() { 
            Console.WriteLine("Company name : " +Employee.companyName);
        }
    }
    class Student {
        private string courseName = "PGCP-AC";

        public string CourseName { 
            get {
                return courseName;
            }
        }
    }
    internal class Program
    {
        Employee emp = new Employee();
        static void Main(string[] args)
        {
            //Student student = new Student();
            //Console.WriteLine(student.CourseName);
            //student.CourseName = "PGCP-BDA";

            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Krushna";
            employee.Salary = 5000000.00f;

            Console.WriteLine(Employee.CompanyName);


            employee.Show();
            Employee.Display();
        }
    }
}
