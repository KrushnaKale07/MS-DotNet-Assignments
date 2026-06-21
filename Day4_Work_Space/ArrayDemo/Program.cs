namespace ArrayDemo
{
    class TestOne { 
        public int[] arr=new int[5];
        public int this[int index] { 
            get { return arr[index]; } 
            set { arr[index] = value; }
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            TestOne t1 = new TestOne();
            t1[0] = 100;
            t1[1] = 200;
        }
        static void Main2(string[] args) { 
            int[] arr = {1,2,3,4,5,6,7,8,9 };
            Console.WriteLine(arr[^1]); //Indices
            Console.WriteLine(arr[^2]);

            int[] arr2 = arr[2..5];     //Ranges

            foreach (int item in arr2)
            {
                Console.WriteLine(item);
            }
        }

        static void Main3(string[] args)
        {
            int[][] arr = new int[3][];

            //Jagged, Ragged Array
            arr[0] = new int[3] { 10, 20, 30 };
            arr[1] = new int[4] { 10, 20, 30, 30 };
        }

        static void Main(string[] args)
        {
            int[] arr = new int[3] { 10, 20, 30 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
