using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numTree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());
            int resultOne = numOne + numTwo;
            int resultTwo = resultOne / numTree;
            int resultTree = resultTwo * numFour;
            Console.WriteLine(resultTree);
        }
    }
}
