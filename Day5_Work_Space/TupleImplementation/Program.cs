namespace TupleImplementation
{
    class Student { 
        
    }
    class Teacher { 
    
    }
    internal class Program
    {
        static (List<Student>, List<Teacher>) GetData()
        {
           List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();

            return (students, teachers);
        }
        static (int, string, int) GetInfo() { 
            int id = 1;
            string name = "Kunal";
            int age = 25;

            return (id, name, age);
        }
        static void Main(string[] args)
        {
            Tuple<int, string, int> tuple = new Tuple<int, string, int>(1, "Krushna", 26);
            Console.WriteLine("Id: "+ tuple.Item1+" Name: "+ tuple.Item2 + " Age: "+ tuple.Item3);

            var info = Program.GetInfo();
            Console.WriteLine(info);

            var myData = Program.GetData();
        }
    }
}
