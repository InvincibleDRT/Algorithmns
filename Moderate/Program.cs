﻿using Moderate.Classes;
using System;
using Leet;
namespace Moderate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //NumberSwapper.SwapNumbers();
            //WordFrequencies.CalculateNumberOfOccurencesOfAWordInBook();
            //InterSectionOfLines.GetInserction();
            //TrailingZeros.NumberOfTrailingZerosInFactorial();
            //SmallestDifference.SmallestDifferenceBetweenArrays();
            // NumberToString.ConvertToString();
            var combos= Leet20.IsValid("([]{})");
            var mergeList = Leet21.MergeTwoLists(Utilities.ConstructListNode(new int[]{1,2,4}),Utilities.ConstructListNode(new int[]{1,3,4}));
            var swapList = Leet24.SwapPairs(Utilities.ConstructListNode(new int[]{1,2,3,4}));
            var len = Leet26.RemoveDuplicates(new int[]{1,1,2});
            len = Leet27.RemoveElement(new int[]{1,1,2},1);
            len = Leet28.StrStr(haystack : "aaaaa", needle : "bba");
            Console.Read();

        }


    }
}
