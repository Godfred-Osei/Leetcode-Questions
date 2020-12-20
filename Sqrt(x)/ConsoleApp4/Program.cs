using System;

namespace ConsoleApp4
{
    class Program
    {
        static int Mysqrt(int x)
        {
            if (x > 0)
            {
                double result = Math.Pow(x, 0.5);
                decimal sqrt = Convert.ToDecimal(result);
                return (int) Math.Floor(sqrt);
            }
            throw new Exception("Not found.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input the integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Mysqrt(num));
        }
    }
}
