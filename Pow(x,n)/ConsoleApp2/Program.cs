using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Base number:");
            int Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the Exponent:");
            int Exponent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("So, the number {0} ^ (to the power) {1} = {2}", Base, Exponent, Power(Base, Exponent));
        }
        static int Power(int Base, int Exponent) 
        {
            int result = 1;
            for(int i = 0; i < Exponent; i++)
            {
                result *= Base;
            }
            return result;
        }
       
       
    }
}
