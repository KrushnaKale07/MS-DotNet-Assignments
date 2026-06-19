namespace Property_Class
{

    class Person
    {
        private string name;
        private int age;

        public string Name          //Property
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be negetive");
                }
                age = value;
            }
        }


        public Person()     //Default Constructor defined by programmer
        {
            this.age = 0;
            this.name = "";
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void Show()
        {
            Console.WriteLine("Name: " + this.Name + " Age: " + this.Age);
        }
    }

    class Student
    {
        public int Id { get; set; }         //Property: private int id, get, set

        public string Name { get; set; }

        public void Show()
        {
            Console.WriteLine("Name: " + this.Name + " Id: " + this.Id);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { Id = 101, Name = "Rushi" };        //Object Initilizer block

            s1.Name = "Kesh";
            s1.Show();
        }

        static void Main2(string[] args)
        {
            Person p1 = new Person(10, "Sandeep");          //p1.Person(&p1)

            p1.Show();
        }
        static void Main1(string[] args)
        {
            Person p = new Person();
            p.Name = "Malkeet";
            p.Age = 36;

            p.Show();

            Student s1 = new Student();       //

            s1.Show();  //s1.Show(&s1)





        }
    }
}
