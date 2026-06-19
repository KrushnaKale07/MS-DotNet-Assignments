namespace ClassAndObjects
{
    class Address
    {

    }
    class Person
    {
        string Name;
        int Age;
        string Address;
        string MoibileNumber;

        Address address;


    }
    class Employee : Person
    {
        private int id;
        string Dept;
        string Designation;
        float Salary;


        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

    }
    class Manager : Employee
    {

    }
    class Admin : Employee
    {

    }
    class Teacher : Employee
    {

    }


    class Shape
    {
        double Area;
        double Parimeter;

        void PrintArea()
        {
            Console.WriteLine("Area: " + Area);
        }
    }
    class Circle : Shape
    {
        double Radious;

    }
    class Student
    {
        public int RollNo;             // Instance Field, They will get memory inside the instance in heap section
        public string Name;
        static string CourseName;       // Non-Instance Field, they will not get memory inside the instance, they will get memory inside class area
        int Age;
        private float fees;

        public void PrintRecord(int x)       //Instance Method, PrintRecord(*this)
        {
            Console.WriteLine("Roll No: " + this.RollNo + " Name: " + this.Name + " CourseName: " + Student.CourseName + " Age: " + this.Age + " Fees: " + this.Fees);
        }

        public float Fees
        {
            get
            {
                return fees;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fees can't be negetive");
                }
                this.fees = value;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Fees = 1000.89f;     //s1.Fees.set(100);

            s1.PrintRecord(100);   //s1.PrintRecord(&s1,100);

            Employee e1 = new Employee();
            e1.Id = 100;
        }
    }
}
