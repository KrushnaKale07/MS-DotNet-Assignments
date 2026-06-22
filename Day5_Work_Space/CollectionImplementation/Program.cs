using System;
using System.Collections;
using System.Data.Common;

namespace CollectionImplementation
{
    internal class Program
    {

        static void Main1(string[] args)
        {
            ArrayList list = new ArrayList();       //Non-Generic Collevction class in C#

            list.Add(1);
            list.Add("Malkeet");
            list.Add(456.78);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            List<int> ints = new List<int>();          //Generic Collection Class

            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            //ints.Add("Malkeet");      //NOT OK

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

        }

    }
}
namespace EmployeeManagement
{
    public interface IEmployeeManager {
        public void AddEmployee();
        public void RemoveEmployee();
        public void UpdateEmployee();
        public void GetAllEmployee();
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
         public string Desig { get; set; }
        public float Salary { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, Designation: {Desig}, Salary: {Salary:C}";
        }
    }

    public class EmployeeManager : IEmployeeManager { 
        public List<Employee> elist = new List<Employee>();

        public EmployeeManager() { 
            elist.Add(new Employee() {Id = 101, Name = "Sanjay", Desig = "Software Dev", Salary= 60000.67f});
            elist.Add(new Employee() { Id = 102, Name = "Navin", Desig = "Dev Op Dev", Salary = 650000.67f });
            elist.Add(new Employee() { Id = 103, Name = "Krushna", Desig = "Testing Engineer", Salary = 160000.67f });
            elist.Add(new Employee() { Id = 104, Name = "Apeksha", Desig = "Software Archi", Salary = 54789.67f });
            elist.Add(new Employee() { Id = 105, Name = "Bhupesh", Desig = "AI Engineer", Salary = 890000.67f });
        }
        public void AddEmployee()
        {
            Employee e = new Employee();
            Console.WriteLine("Enter Employee Id");
            e.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            e.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Desig");
            e.Desig = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            e.Salary = Convert.ToSingle(Console.ReadLine());

            elist.Add(e);

            Console.WriteLine("Employee Added Successfully");
        }

        public void RemoveEmployee()
        {
            int id;
            Console.WriteLine("Enter Employee Id");
            id = Convert.ToInt32(Console.ReadLine());

            bool flag = false;

            foreach (Employee e in elist) {
                if (e.Id == id) {
                    flag = true;
                    elist.Remove(e);
                    Console.WriteLine("Record Deleted");
                    break;
                }
            }
            if (flag == false) {
                Console.WriteLine("Record Not F ound");
            }
        }

        public void UpdateEmployee()
        {
            int id;
            Console.WriteLine("Enter Employee Id");
            id = Convert.ToInt32(Console.ReadLine());

            bool flag = false;

            foreach (Employee e in elist) {
                if (e.Id == id) { 
                    flag = true;
                    Console.WriteLine("Enter Employee Name");
                    e.Name = Console.ReadLine();

                    Console.WriteLine("Enter Employee Desig");
                    e.Desig = Console.ReadLine();

                    Console.WriteLine("Enter Employee Salary");
                    e.Salary = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Record Updated");
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Record Not Found");
            }
        }

        public void GetAllEmployee()
        {
            foreach (Employee emp in elist)
            {
                Console.WriteLine(emp);
            }
        }

        internal class TestEmpMan
        {
            static void Main()
            {
                EmployeeManager manager = new EmployeeManager();

                int choice = 0;

                do
                {
                    Console.WriteLine("-----------------------------------Employee Management---------------------------------");
                    Console.WriteLine("Press 1 to Add Employee");
                    Console.WriteLine("Press 2 to Delete Employee");
                    Console.WriteLine("Press 3 to Update Employee");
                    Console.WriteLine("Press 4 to GetAll Employee");
                    Console.WriteLine("Press 5 to Exit The Program");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine("Enter Your Choice");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                manager.AddEmployee();
                                break;
                            }
                        case 2:
                            {
                                manager.RemoveEmployee();
                                break;
                            }
                        case 3:
                            {
                                manager.UpdateEmployee();
                                break;
                            }
                        case 4:
                            {
                                manager.GetAllEmployee();
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("Exiting Program");
                                break;
                            }
                    }
                } while (choice != 5);


            }
        }
        }
    }
