
using System;

namespace PowerOfThree
{
    class Program
    {
        static bool powerOfThree(int n)
        {
            int num = n;
            int i = 0;
            while (n > 0)
            {
                if (n == Math.Pow(3, i))
                {
                    return true;
                }
                n = n / 3;
                i++;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(powerOfThree(n));
        }
    }
}
