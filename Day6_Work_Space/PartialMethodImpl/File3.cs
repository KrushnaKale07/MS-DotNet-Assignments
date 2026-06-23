using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodImpl
{
    public partial class Person
    {
        public partial void GetData()
        {
            Console.WriteLine("Enter Id");
            this.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            this.Age = Convert.ToInt32(Console.ReadLine());
        }
        public partial void PrintData() {
             Console.WriteLine("Id: " + this.Id + " Name: " + this.Name + " Age: " + this.Age);
        }
    }
}
