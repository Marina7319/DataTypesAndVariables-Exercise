using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int i = 0;
            while (i < n)
            {
                i++;
                char p = char.Parse(Console.ReadLine());
                totalSum += (int)p;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
