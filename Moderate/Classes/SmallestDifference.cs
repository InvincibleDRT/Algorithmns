using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Classes
{
    class SmallestDifference
    {
        public static void SmallestDifferenceBetweenArrays()
        {
            int[] array1 = new int[] {1, 2, 4, 7, 9};
            int[] array2 = new int[] {200,8,206,400,12};
            Array.Sort(array1);
            Array.Sort(array2);
            int? minDiff = null;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    int diff = Math.Abs(array1[i] - array2[j]);
                    if (minDiff == null || minDiff > diff)
                    {
                        Pos1 = i;
                        Pos2 = j;
                        minDiff = diff;
                    }
                    else
                        break;
                }
            }
            Console.WriteLine($"Smallest Difference between two arrays is {minDiff}");
            Console.Read();

        }


            public static int Pos1 { get; set; }
            public static int Pos2 { get; set; }

    }
}
