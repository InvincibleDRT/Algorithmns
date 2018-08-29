using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate
{
    class NumberSwapper
    {
        public  int num1;
        public  int num2;

        public NumberSwapper(int n1, int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public static NumberSwapper ClassicSwap(NumberSwapper numbers)
        {
            numbers.num1 = numbers.num1 - numbers.num2;
            numbers.num2 = numbers.num1 + numbers.num2;
            numbers.num1 = numbers.num2 - numbers.num1;

            return numbers;
        }

        public static NumberSwapper BinarySwap(NumberSwapper numbers)
        {
            numbers.num1 = numbers.num1 ^ numbers.num2;//xor
            numbers.num2 = numbers.num2 ^ numbers.num1;
            numbers.num1 = numbers.num1 ^ numbers.num2;
            return numbers;
        }
    }
}
