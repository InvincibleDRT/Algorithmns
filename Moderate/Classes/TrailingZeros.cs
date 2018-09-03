using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Classes
{
    class TrailingZeros
    {
        public static void NumberOfTrailingZerosInFactorial()
        {
            Console.WriteLine("Enter the factorial you want to Calculate");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Number of Zeros in {number}! is  {CalculateZeros(number)}");

            Console.ReadLine();
        }
        
        private static int CalculateZeros(int number)
        {
            int numOfFives = number / 5;
            if (numOfFives > 5)
                return numOfFives + CalculateZeros(numOfFives);
            return numOfFives;
        }

    }
}
