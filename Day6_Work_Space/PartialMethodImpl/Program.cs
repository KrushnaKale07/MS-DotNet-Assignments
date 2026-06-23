namespace PartialMethodImpl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            //person.Id = 1;
            //person.Name = "Test";
            //person.Age = 30;

            person.GetData();
            person.PrintData();
        }

    }
}
