using System;

namespace PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            for (char i = (char)numOne; i <= numTwo; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
