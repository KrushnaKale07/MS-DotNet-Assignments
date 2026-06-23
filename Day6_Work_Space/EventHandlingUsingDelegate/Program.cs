namespace EventHandlingUsingDelegate
{
    public class EventHandling {
        public delegate void ScoreHandler(int score);

        public static event ScoreHandler scoreReached;

        static void Main1(string[] args)
        {
            scoreReached += onScoreReached;

            int score = 0;

            for(int i = 0; i < 60; i++){
                score = i;

                Console.WriteLine("Courrent Score "+score);
                Thread.Sleep(1000);
                if (score>=50) {

                    //Raise the Event which is defined as ref variable of delegate
                    scoreReached?.Invoke(score);
                    break;
                }
            }
        }

        static void onScoreReached(int score) {
            Console.WriteLine("Event Triggered the score is: " + score);
        }

    }
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //    }
    //}
}
namespace AnonymousTypes
{
    internal class Program
    {
        static void Main1()
        {
            var person = new { Name = "Krushna", Age = 26, Salary = 80000.56 };
            Console.WriteLine("name : " + person.Name + " Age : " + person.Age + " Salary : " + person.Salary);

        }
    }
}
namespace ExtentionMethod {
    class Test {
        public void Display() {
            Console.WriteLine("Am Display of Test");

        }
    }

    static class ExtentionMethodClass {
        public static void ExtendedShow( this Test test) { 
            Console.WriteLine("Am Show of Test defined as Extention method"); 
        }
    }

    internal class Program {
        static void Main() { 

            Test t = new Test();

            t.Display();
            t.ExtendedShow();
        }
    }

}
