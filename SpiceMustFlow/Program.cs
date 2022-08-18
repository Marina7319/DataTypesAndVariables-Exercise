using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int i = 100;
            int countDays = 0;
            int sum = 0;
            while (i <= yield)
            {
                sum += yield - 26;
                yield = yield - 10;
                countDays++;
            }
            if (sum > 0)
            {
                sum = sum - 26;
            }
            Console.WriteLine(countDays);
            Console.WriteLine(sum);
        }
    }
}
