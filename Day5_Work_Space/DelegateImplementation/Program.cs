namespace DelegateImplementation
{
    public delegate int MathOp(int a, int b);

    public delegate void Display();
    internal class Program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x -  y;
        }

        public static void Method1() {
            Console.WriteLine("Method1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2");
        }


        static void Main3(string[] args) {
           Display d = new Display(Method1);
            d += Method2;
            d();
        }

        static void Main2(string[] args)
        {
            MathOp op1 = new MathOp(Add);
            MathOp op2 = new MathOp(Sub);

            int sum = op1(100,200);
            int sub  = op2(100,200);

            Console.WriteLine(sum);
            Console.WriteLine(sub);

        }
        static void Main1(string[] args)
        {
            MathOp op = new MathOp(Add);

            int result = op(10,20);

            Console.WriteLine(result);
        }
    }
}

namespace DefineDelegates
{
    internal class DefinedDelegate {

        public static void Show() { 
            Console.WriteLine("AM Show");
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static bool CheckAge(int Age) {
            if (Age > 18) {
                return true;
            }
            return false;
        }
        static void Main() {
            Predicate<int> p = new Predicate<int>(CheckAge);
            Console.WriteLine(p(18));

            Predicate<int> isEven = (num) => num % 2 == 0;
            Console.WriteLine(isEven(21));
        }
        static void Main2(string[] args)
        {
            //Func<int, int, int> f1 = (a , b)=> a + b;
          
            Func<int, int, int> f1 = new Func<int, int, int>(Add);

            int sum = f1(100, 200);

            Console.WriteLine(sum);


            Func<string, string, string> con = (str1, str2) => str1 + str2;

            Console.WriteLine(con("Krushna", "Kale"));
        }
            static void Main1(string[] args) {
            Action a1 = new Action(Show);
            a1();

            Action<string> action = name => Console.WriteLine("Hello : "+name);
            action("Krushna");
        }
    }
}
