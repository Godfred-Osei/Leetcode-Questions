using System;

namespace DivideTwoNumber
{
    class Program
    {
        static int Divide(int dividend, int divisor)
        {
            //create a variable to store the remainder
            int remainder;

            //Takes care of the Integer overflow 
            if(dividend == Int32.MinValue && divisor == -1)
            {
                return Int32.MaxValue;
            }
            if(dividend == Int32.MinValue && divisor == 1)
            {
                return Int32.MinValue;
            }

            //calculate the quotient of two numbers
            int quotient = Math.DivRem(dividend, divisor, out remainder);
            return quotient;
        }
        static void Main(string[] args)
        {
            //Get dividend from user input
            Console.WriteLine("Enter the dividend:");
            int dividend = Convert.ToInt32(Console.ReadLine());

            //Get divisor from user input
            Console.WriteLine("Enter the divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //Invoke a method and prints the outcome on the console screen
            Console.WriteLine(Divide(dividend, divisor));

        }
    }
}
