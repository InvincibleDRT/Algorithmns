using System;

namespace Moderate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //SwapNumbers();
        }
        private static void SwapNumbers()
        {
            Console.WriteLine("Please enter Number 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Number2");
            int n2 = int.Parse(Console.ReadLine());
            NumberSwapper numbers = new NumberSwapper(n1, n2);
            numbers=NumberSwapper.ClassicSwap(numbers);
            DisplayNumbers(numbers);
            Console.WriteLine("performing BinarySwap on the swapped numbers");
            numbers = NumberSwapper.BinarySwap(numbers);
            DisplayNumbers(numbers);
            Console.Read();
        }

        private static void DisplayNumbers(NumberSwapper numbers)
        {
            Console.WriteLine(numbers.num1 + "\r\n is the first Number after swap");
            Console.WriteLine(numbers.num2 + "\r\n is the second Number after swap");
        }
    }
}
