using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class TestOne
    {
        public static int Add(int x, int y) {
            return x + y; 
        }
        public static int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public static int Add(int w,int x, int y, int z)
        {
            return w + x + y + z;
        }
    }

    class TestTwo {
        public static int Add(int w, int x, int y = 0, int z = 0)
        {
            return w + x + y + z;
        }
    }

    class TestThree {

        public static int Add(int w, int x, params int[] numbers)
        {
            int total = 0;
            foreach ( int a in numbers ) { 
                total+= a;
            }   
             return total;
        }
    }
    internal class MethodOverloading
    {
        static void Main1(String[] args) {
            //int sum1 = TestOne.Add(1, 2);
            //int sum2 = TestOne.Add(2, 3, 4);
            //int sum3 = TestOne.Add(4, 5, 6, 7);
            //Console.WriteLine("Sum1 is : " + sum1 + " Sum2 : " + sum2 + " Sum3 : " + sum3);


            //int sum = TestTwo.Add(10,20);
            //Console.WriteLine(sum);

            int sum =  TestThree.Add(1, 2, 10,2,0,4,1,2,4,4);
            Console.WriteLine(sum);
        }
    }
}
namespace MethodOverTypeParamters {
    class TestOne {
        public static void Print(int a) {
            Console.WriteLine(a);
        }

        public static void Print(String name)
        {
            Console.WriteLine(name);
        }
    }

    internal class Program {
        static void Main(String[] args)
        {
            TestOne.Print(1);
            TestOne.Print("Malkit");
        }
    }
}

namespace InnerMethod {
    class TestThree { 
        
    }
}