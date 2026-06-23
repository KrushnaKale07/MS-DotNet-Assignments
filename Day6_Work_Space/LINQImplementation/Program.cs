namespace LINQImplementation
{
    class Student { 
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();

            list.Add(new Student { Id = 101, Name = "Sanjay", Age = 24 });
            list.Add(new Student { Id = 102, Name = "Abhi", Age = 22 });
            list.Add(new Student { Id = 103, Name = "Zeenat", Age = 28 });
            list.Add(new Student { Id = 105, Name = "Celena", Age = 31 });
            list.Add(new Student { Id = 104, Name = "Bimal", Age = 37 });

            var age25 = from s in list where s.Age > 25 select s;

            foreach ( Student s in age25) { 
                Console.WriteLine("Name: "+s.Name+" Age: " + s.Age);
            }
        }
    }
}
