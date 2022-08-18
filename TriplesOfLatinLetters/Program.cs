using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int x = 0; x < n; x++)
                    {
                        char firstChar = (char)('a' + i);
                        char seondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + x);
                        Console.WriteLine($"{firstChar}{seondChar}{thirdChar}");
                    }
                }
            }

        }
    }
}
