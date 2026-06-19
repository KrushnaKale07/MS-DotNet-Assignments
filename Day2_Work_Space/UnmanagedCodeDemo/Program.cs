using System.Runtime.InteropServices;
namespace UnmanagedCodeDemo
{
    internal class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int frequency, int duration);

        static void Main(string[] args)
        {
            Beep(750, 1000);
        }
    }
}
