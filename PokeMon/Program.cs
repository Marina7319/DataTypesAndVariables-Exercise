using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int pokesCount = 0;
            int sum = N;
            while (N >= M)
            {
                N = N - M;
                pokesCount++;
                double percentOfSum = sum * 0.5;
                if (N == percentOfSum)
                {
                    if (Y != 0)
                    {
                        N = N / Y;
                    }
                }
            }
            Console.WriteLine(N);
            Console.WriteLine(pokesCount);
        }
    }
}
