namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num = 20;
            int num1 = num;
            long num2 = num1;
            double num3 = num2;
            //Console.WriteLine("byte num: " + num + " int num1: " + num1 + " long num2: " + num2+ " and double num3: " + num3);

            num1 = (int)num3;
            short num4 = (short)num1;
            //Console.WriteLine("short num4: " + num4 + " int num1: " + num1 + " and double num3: " + num3);

            float num5 = 100.256f;
            num1 = (int)num5;
            //Console.WriteLine("int num1: " + num1 + " float num5: " + num5 + " and the data loss during the conversion is " + (num5 - num1));

            char ch = 'A';
            int a = ch;
            //Console.WriteLine("the ASCII/Unicode value of "+ ch +" is " + a);

            char ch2 = (char)a;
            //Console.WriteLine("the corresponding character of int value " + a + " is "+ ch2);

            string str1 = "123";
            int parse = int.Parse(str1);
            //Console.WriteLine("a numeric string "+ str1 + " Converts it to int using int.Parse() : " + parse );

            string str2 = "true";
            bool result = !bool.Parse(str2);
            Console.WriteLine(result);
        }
    }
}
