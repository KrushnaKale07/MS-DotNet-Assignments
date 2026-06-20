

using EmployeeExample;

namespace TestOne
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int Number1 = 10;
            string Name = "Malkeet";

            Console.WriteLine("Number : "+Number1+" Name : "+Name);
            Console.WriteLine("Number:{0}, Name {1}", Number1, Name);
            Console.WriteLine($"Number : {Number1}, Name : {Name}");
        }
    }
}
namespace TestTwo
{
    class TestOne {
        public TestOne()
        {
            Console.WriteLine("Zero Args Cons");
        }
        public TestOne(int x) : this()
        {
            Console.WriteLine("One Args Cons");
        }
        public TestOne(int x, int y) : this(x)
        {
            Console.WriteLine("Two Args Cons");
        }
        public TestOne(int x, int y, int z) : this(z,y)
        {
            Console.WriteLine("Three Args Cons");
        }

        internal class TestOneDemo { 
            static void Main1() { 

                //TestOne t1 = new TestOne();
                //TestOne t2 = new TestOne(10);
                //TestOne t3 = new TestOne(20, 30);
                //TestOne t4 = new TestOne(40,50,60);

                TestOne t5 = new TestOne(1, 2, 3);
            }
        }
    }
}
namespace TestThree
{
    class TestThree
    {

        public int x;
        public TestThree()
        {
            Console.WriteLine("Am zero args cons of TestThree");
        }
        public TestThree(int x)
        {
            this.x = x;
            Console.WriteLine("Am one args cons of TestThree");
        }
    }
    class TestFour : TestThree {
        public int y;
        public TestFour() {
            Console.WriteLine("Am zero args cons of TestFour");
        }
        public TestFour(int x, int y) : base(x)
        {
            this.y = y;
            Console.WriteLine("Am one args cons of TestFour");
        }
    }

    internal class TestConsHeiarachy {
        static void Main1() { 
            TestFour t1 = new TestFour(10,20);
        }
    }
}
namespace EmployeeExample {
    class Employee {
        public int Id;
        public string Name;

        public Employee() { 
            
        }
        public Employee(int id, string name) { 
            Id = id;
            Name = name;
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Id: " + this.Id + " Name: " + this.Name);
        }
    }

    class EmployeeManager : Employee {
        public int TeamSize;
        public string DeptName;

        public EmployeeManager() { 
            
        }

        public EmployeeManager(int teamSize, string depyName, int id, string name) : base(id, name)
        { 
            TeamSize = teamSize;
            DeptName = depyName;
        }

        public void PrintEM()
        {
            this.PrintEmployee();
            Console.WriteLine("TeamSize : "+ this.TeamSize + " DeptName : " + this.DeptName);
        }
    }

    internal class EmployeeMtest {
        static void Main1() { 
            EmployeeManager manager = new EmployeeManager(10, "Computer", 101, "Krushna");
            manager.PrintEM();
        }
    }
}
namespace AccessModifiers {
    class TestOne
    {
        private int id;
        protected int age;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
    class TestTwo : TestOne
    {
        private string name;

        void Show()
        {
            Console.WriteLine("Id: " + this.Id + " Name: " + this.name + " Age: " + this.age);
        }
    }
}