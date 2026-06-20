namespace TestOne
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            int Number1 = 10;
            string Name = "Malkeet";

            Console.WriteLine("Number : "+Number1+" Name : "+Name);
            Console.WriteLine("Number:{0}, Name {1}", Number1, Name);
            Console.WriteLine($"Number : {Number1}, Name : {Name}");
        }
    }
}
namespace TestTwo
{
    class TestOne {
        public TestOne()
        {
            Console.WriteLine("Zero Args Cons");
        }
        public TestOne(int x) : this()
        {
            Console.WriteLine("One Args Cons");
        }
        public TestOne(int x, int y) : this(x)
        {
            Console.WriteLine("Two Args Cons");
        }
        public TestOne(int x, int y, int z) : this(z,y)
        {
            Console.WriteLine("Three Args Cons");
        }

        internal class TestOneDemo { 
            static void Main1() { 

                //TestOne t1 = new TestOne();
                //TestOne t2 = new TestOne(10);
                //TestOne t3 = new TestOne(20, 30);
                //TestOne t4 = new TestOne(40,50,60);

                TestOne t5 = new TestOne(1, 2, 3);
            }
        }
    }
}
namespace testThree
{
    class TestThree
    {

        public int x;
        public TestThree()
        {
            Console.WriteLine("Am zero args cons of TestThree");
        }
        public TestThree(int x)
        {
            this.x = x;
            Console.WriteLine("Am one args cons of TestThree");
        }
    }
    class TestFour : TestThree {
        public int y;
        public TestFour() {
            Console.WriteLine("Am zero args cons of TestFour");
        }
        public TestFour(int x, int y) : base(x)
        {
            this.y = y;
            Console.WriteLine("Am one args cons of TestFour");
        }
    }

    internal class TestConsHeiarachy {
        static void Main() { 
            TestFour t1 = new TestFour(10,20);
        }
    }
}