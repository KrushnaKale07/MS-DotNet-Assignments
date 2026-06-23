namespace EventHandlingUsingDelegate
{
    public class EventHandling {
        public delegate void ScoreHandler(int score);

        public static event ScoreHandler scoreReached;

        static void Main(string[] args)
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
