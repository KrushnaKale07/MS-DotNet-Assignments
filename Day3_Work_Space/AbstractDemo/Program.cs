namespace AbstractDemo
{
    abstract class Person { 
        public int Age { get; set; }
        public string Name { get; set; }

        abstract public void PrintData();
    }

    class Employee : Person { 
        public int Id { get; set; }
        public float Salary { get; set; }
        public string Deptname { get; set; }

        public override void PrintData()
        {

            Console.WriteLine("Id : " + this.Id + " Salary : " + this.Salary + " DeptName : "+ this.Deptname +" Name : " + this.Name+ " Age : "+this.Age);
        }
    }

    class Student : Person { 
        public int RollNo { get; set; }
        public int Marks { get; set; }

        public override void PrintData() {
            Console.WriteLine("Roll No : "+this.RollNo+" Name : "+ this.Name+" Age : " + this.Age+ " Marks : " + this.Marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee() { Name = "Krushna", Age = 26, Deptname= " Mech", Salary=50000.00f, Id=101};
            emp.PrintData();
            Student s1 = new Student();
        }
    }
}
