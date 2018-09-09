using System;
using System.Collections.Generic;
using System.Text;
using Moderate.Extensions;

namespace Moderate.Classes
{
    class NumberToString
    {
        public static void ConvertToString()
        {
            Console.WriteLine("enter a number to convert to string ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num.ToStringExnteded());
        }
    }
}
