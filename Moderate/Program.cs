using Moderate.Classes;
using System;
using Leet;
using System.Collections.Generic;
using System.Linq;

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
            len = Leet29.Divide(-2147483648,3);
            var searchList = Leet30.FindSubstring("barfoothefoobarman",new string[]{"foo","bar"});
              searchList = Leet30.FindSubstring("wordgoodgoodgoodbestword",new string[]{"word","good","best","word"});
            var rv = Leet30.GetPermutations(new string[]{"foo","bar"});
            rv =Leet30.GetPermutations(new string[]{"word","good","best","good"});
            var intlist = Leet30.GetPositions("wordgoodgoodgoodbestword", new string[]{"word","good","best","good"});
            intlist = Leet30.GetPositions("foobarfoobar", new string[]{"bar","foo"});
            intlist = Leet30.GetPositions("", new string[]{});
            
            Dictionary<string,double> vartestdict = new Dictionary<string, double>(){
                {"1",69.5},
                {"2",29.501},
                {"3",0.999}
            };
            var result= PerformRoundOff(vartestdict);
            Console.Read();
        }

        
        public static Dictionary<string,double> PerformRoundOff(Dictionary<string,double> performanceLevels)
        {
            var total = performanceLevels.Values.Sum();
            var returnDict = new Dictionary<string, double>();
            var floorDict = new Dictionary<string, double>();
            foreach (var kvp in performanceLevels)
            {
                var val = (kvp.Value * 100.0) / total;

                returnDict.Add(kvp.Key, val);
            }

            Dictionary<string, double> mantissaLookup = new Dictionary<string, double>();
            foreach (var item in returnDict)
            {
                var integralPart = Math.Truncate(item.Value);
                integralPart= integralPart ==0 && item.Value > 0 ? integralPart+1 : integralPart;
                floorDict.Add(item.Key, integralPart);
                mantissaLookup.Add(item.Key, item.Value - integralPart);
            }
            double offset = 100.0 - floorDict.Values.Sum();
            foreach (var item in mantissaLookup.OrderByDescending(x => x.Value).ThenByDescending(x => x.Key))
            {
                if (offset > 0.0)
                {
                    floorDict[item.Key] = floorDict[item.Key] + 1;
                }
                else
                    break;
                offset--;
            }
            return floorDict;
        }


    }
}
