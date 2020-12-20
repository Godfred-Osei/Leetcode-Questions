using System;

namespace ConsoleApp4
{
    class Program
    {
        // Leetcode Power Of Two (Question number 231)
        static bool isPowerOfTwo(int n)
        {
            // Reassign the value of n to num
            int num = n;

            //asign the exponent to zero
            int i = 0;

            while (n > 0)
            {
                // this checks whether num is equal to 2 raised to the power i
                // where i is initialized to zero
                if(num == Math.Pow(2, i))
                {
                    return true;
                }
                n = n / 2;
                i++;
               
               
            }
            return false;
        }
        static void Main(string[] args)
        {
            // Get user input for the number             
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Invoke and prints the method on the console
            Console.WriteLine(isPowerOfTwo(n));
        }
    }
}
