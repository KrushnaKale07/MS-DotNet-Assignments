
namespace LINQImplementation
{
    class Student { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {

        static void Main()
        {
            List<Student> list = new List<Student>();

            list.Add(new Student { Id = 101, Name = "Sanjay", Age = 24 });
            list.Add(new Student { Id = 102, Name = "Abhi", Age = 22 });
            list.Add(new Student { Id = 103, Name = "Zeenat", Age = 28 });
            list.Add(new Student { Id = 105, Name = "Celena", Age = 31 });
            list.Add(new Student { Id = 104, Name = "Bimal", Age = 37 });


            var students = (from s in list orderby s.Id descending select s).Take(3);

            int count = (from s in list orderby s.Id descending select s).Count();

            //Console.WriteLine(count);

            foreach (Student s in students)
            {
                Console.WriteLine("Id: " + s.Id + " Name: " + s.Name + " Age: " + s.Age);
            }

        }

        static void Main3(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student { Id = 101, Name = "Sanjay", Age = 24 });
            list.Add(new Student { Id = 102, Name = "Abhi", Age = 22 });
            list.Add(new Student { Id = 103, Name = "Zeenat", Age = 28 });
            list.Add(new Student { Id = 105, Name = "Celena", Age = 31 });
            list.Add(new Student { Id = 104, Name = "Bimal", Age = 37 });

            // We can LINQ Query as Query or Methods syntax

            //Query Syntax

            var age25 = from s in list where s.Age > 25 orderby s.Name select s;

            foreach (Student item in age25)
            {
                Console.WriteLine("Id: " + item.Id + " Name: " + item.Name + " Age: " + item.Age);
            }
        }

            static void Main2(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student { Id = 101, Name = "Sanjay", Age = 24 });
            list.Add(new Student { Id = 102, Name = "Abhi", Age = 22 });
            list.Add(new Student { Id = 103, Name = "Zeenat", Age = 28 });
            list.Add(new Student { Id = 105, Name = "Celena", Age = 31 });
            list.Add(new Student { Id = 104, Name = "Bimal", Age = 37 });

            var age25 = from s in list where s.Age > 25 select s; //LINQ Query

            var age252 = list.Where(s => s.Age > 25).ToList<Student>(); //Immediate Execution

            var list2 = list.ToList<Student>(); //Immediate Execution

            list.Add(new Student { Id = 106, Name = "Asha", Age = 33 });

            //Deffered Execution
            foreach (Student s in age25)
            {
                Console.WriteLine("Name: " + s.Name + " Age: " + s.Age);
            }

            //foreach (Student s in list2)
            //{
            //    Console.WriteLine("Name: " + s.Name + " Age: " + s.Age);
            //}
        }

        static void Main1(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student { Id = 101, Name = "Sanjay", Age = 24 });
            list.Add(new Student { Id = 102, Name = "Abhi", Age = 22 });
            list.Add(new Student { Id = 103, Name = "Zeenat", Age = 28 });
            list.Add(new Student { Id = 105, Name = "Celena", Age = 31 });
            list.Add(new Student { Id = 104, Name = "Bimal", Age = 37 });

            var age25 = from s in list where s.Age > 25 select s; //LINQ Query

            foreach ( Student s in age25) { 
                Console.WriteLine("Name: "+s.Name+" Age: " + s.Age);
            }
        }
    }
}
