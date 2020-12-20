using System;

namespace ReverseInteger
{
    class Program
    {
        static int Reverse(int x)
        {
            int length = Convert.ToString(x).Length;
            if (x < 0)
            {
                length--;
            }
            long ReverseNum = 0;
            for(int i = 0; i < length; i++)
            {
                ReverseNum = ReverseNum * 10 + x % 10;
                if(ReverseNum > Int32.MaxValue || ReverseNum < Int32.MinValue)
                {
                    return 0;
                }
                x = x / 10;
            }
            return (int)ReverseNum;
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine("Input the integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Reverse(num));
            
        }
    }
}
