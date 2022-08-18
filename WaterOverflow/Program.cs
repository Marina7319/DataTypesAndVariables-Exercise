using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int litersWater = 0;
            for (int i = 0; i < n; i++)
            {
                int q = int.Parse(Console.ReadLine());
                if (255 >= litersWater)
                {
                    litersWater += q;
                    if (litersWater > 255)
                    {
                        Console.WriteLine("Insufficient capacity!");

                        litersWater -= q;
                    }
                }
            }
            Console.WriteLine($"{litersWater}");
        }
    }
}