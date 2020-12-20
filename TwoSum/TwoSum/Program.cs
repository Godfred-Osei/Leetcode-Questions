using System;

namespace TwoSum
{
    class Program
    {
        static int[] TwoSum(int[] array, int target)
        {
            for(int i = 0; i < array.Length; i++)
            {

                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[i] + array[j] == target)
                    {
                        return new int[] { i, j }; 
                    }
                }

            }
            throw new Exception("Not found.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of your array:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input your target:");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Elements of the array are: ");

            int[] array = new int[length];
            for(int i = 0; i < length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine(TwoSum(array, target));
           
        }
    }
}
