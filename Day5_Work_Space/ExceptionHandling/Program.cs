namespace ExceptionHandling
{


    public class InvalidAgeException : Exception { 
        public InvalidAgeException(string str) : base(str) { }
    }
    internal class Program
    {

        public static void CheckAge(int Age) {
            if (Age < 18) {
                throw new ArgumentException("Age is less then 18");
            }
            Console.WriteLine("You can vote");
        }

        static void Main(string[] args)
        {
            try
            {
                Program.CheckAge(19);
            }
            catch (InvalidAgeException e) {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Rest of my program");
        }

            static void Main1(string[] args)
        {
            int num1 = 100;
            int num2 = 0;
            float res = 0.0f;

            try
            {
                res = num1 / num2;
                Console.WriteLine("Res: " + res);
            }
            catch (DivideByZeroException ex) { 
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Rest of my program");
        }
    }
}
