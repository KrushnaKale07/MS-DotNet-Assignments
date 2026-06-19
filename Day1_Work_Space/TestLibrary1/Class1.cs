using MyLibrary1;

namespace TestLibrary1
{
    internal class Program
    {

        static void Main(String[] args) {
            MathOp ol = new MathOp();
            int sum = ol.Add(10,20);
            Console.WriteLine(sum);
        } 

    }
}
