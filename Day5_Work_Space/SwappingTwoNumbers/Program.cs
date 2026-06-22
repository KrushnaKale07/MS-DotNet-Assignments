namespace SwappingTwoNumbers
{
    internal class Program
    {

        public static void Swapping<T>(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine($"Before Swap: x = { x}, y = {y}");
            Swapping<int>(ref x, ref y);
            Console.WriteLine($"After Swap; x = {x}, y = {y}");
            string str1 = "Hello", str2 = "World";
            Console.WriteLine($"\nBefore Swap: str1 = {str1}, str2 = {str2} ");
            Swapping<string>(ref str1, ref str2);
            Console.WriteLine($"\nAfter Swap: str1 = {str1}, str2 ={str2}");

        }
    }
}
