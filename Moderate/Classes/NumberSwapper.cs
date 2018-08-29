using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate
{
    class NumberSwapper
    {
        public  int num1;
        public  int num2;

        private NumberSwapper(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        private static NumberSwapper ClassicSwap(NumberSwapper numbers)
        {
            numbers.num1 = numbers.num1 - numbers.num2;
            numbers.num2 = numbers.num1 + numbers.num2;
            numbers.num1 = numbers.num2 - numbers.num1;

            return numbers;
        }

        private static NumberSwapper BinarySwap(NumberSwapper numbers)
        {
            numbers.num1 = numbers.num1 ^ numbers.num2;//xor
            numbers.num2 = numbers.num2 ^ numbers.num1;
            numbers.num1 = numbers.num1 ^ numbers.num2;
            return numbers;
        }

        public static void SwapNumbers()
        {
            Console.WriteLine("Please enter Number 1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter Number2");
            int n2 = int.Parse(Console.ReadLine());
            NumberSwapper numbers = new NumberSwapper(n1, n2);
            numbers = NumberSwapper.ClassicSwap(numbers);
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
