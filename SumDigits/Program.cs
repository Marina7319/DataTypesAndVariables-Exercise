using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int nums = num % 10;
                sum += nums;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
