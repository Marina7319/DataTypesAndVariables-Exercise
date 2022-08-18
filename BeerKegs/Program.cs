using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxNum = double.MinValue;
            double result = 0;
            string keg = "";
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double r = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double sum = Math.PI * Math.Pow(r, 2) * h;
                result += sum;
                if (sum > maxNum)
                {
                    maxNum = sum;
                    keg = model;
                }
            }
            Console.WriteLine(keg);
        }
    }
}
