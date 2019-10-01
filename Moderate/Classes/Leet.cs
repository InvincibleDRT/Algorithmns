﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Leet
{

    public class Leet8
    {
        public static int MyAtoi(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            str = str.TrimStart();
            char signal = str[0];
            string parsedString = string.Empty;
            bool hasSign = signal == '-' || signal == '+';
            parsedString = PerformConversion(str, hasSign);
            if (string.IsNullOrEmpty(parsedString))
            {
                return 0;
            }
            else
            {
                parsedString = hasSign ? signal + parsedString : parsedString;
                try
                {
                    long parsedVal = long.Parse(parsedString);
                    if (parsedVal > Int32.MaxValue)
                        return Int32.MaxValue;
                    else if (parsedVal < Int32.MinValue)
                        return Int32.MinValue;
                    else
                        return (int)parsedVal;
                }
                catch
                {
                    if (signal == '-')
                        return Int32.MinValue;
                    else
                        return Int32.MaxValue;
                }
            }
        }

        public static string PerformConversion(string str, bool hasSign)
        {
            int val = 0;
            int index = hasSign ? 1 : 0;
            string returnString = string.Empty;
            if (index == str.Length)
                return null;
            while (int.TryParse(str[index].ToString(), out val))
            {
                returnString = returnString + str[index];
                index++;
                if (index == str.Length)
                    break;
            }

            if (string.IsNullOrEmpty(returnString))
                return null;
            else
                return returnString;
        }

    }

    public class Lett9
    {
        public static bool IsPalindrome(int x)
        {
            string y = x.ToString();
            int i = 0;
            while (i < y.Length)
            {
                if (y[i] != y[y.Length - i - 1])
                    return false;
                i++;
            }
            return true;
        }
    }
    public class Leet11
    {

        public static int MaxArea(int[] strs)
        {
            int maxArea = 0;
            int r = strs.Length - 1;
            int l = 0;
            while (l < r)
            {
                maxArea = Math.Max(maxArea, Math.Min(strs[l], strs[r]) * (r - l));
                if (strs[r] < strs[l])
                    r--;
                else
                    l++;
            }
            Console.Write($"Max Area is {maxArea}");
            return maxArea;
        }

    }

    public class Lett12
    {
        public static string IntToRoman(int num)
        {

            string[] M = { "", "M", "MM", "MMM" };
            string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
        }
    }


    public class Lee13
    {
        public static int RomanToInt(string num)
        {
            int tempSum = 0;
            int prevValue = 0;
            Dictionary<char, int> stringToIntDict = new Dictionary<char, int>() { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } }; //and so on.....
            for (int i = num.Length - 1; i >= 00; i--)
            {
                int current = stringToIntDict[num[i]];
                if (prevValue == 0)
                    prevValue = current;
                if (prevValue > current)
                    tempSum -= current;
                else tempSum += stringToIntDict[num[i]];
                prevValue = current;
            }
            return tempSum;
        }
    }


    public class Leet14
    {
        public static string MaxArea(string[] strs)
        {
            string commonString = "";
            if (strs.Length == 0)
                return commonString;
            else if (strs.Length == 1)
                return strs[0];
            if (strs[0].Length < strs[1].Length)
            {
                commonString = CommonString(strs[0], strs[1]);
            }
            else
            {
                commonString = CommonString(strs[1], strs[0]);
            }

            for (int i = 1; i < strs.Length; i++)
            {
                if (strs.Length == i + 1)
                {
                    continue;
                }
                if (commonString.Length < strs[i + 1].Length)
                {
                    commonString = CommonString(commonString, strs[i + 1]);
                }
                else
                {
                    commonString = CommonString(strs[i + 1], commonString);
                }

                if (string.IsNullOrEmpty(commonString))
                    return "";
            }
            return commonString;
        }

        public static string CommonString(string shortString, string longString)
        {
            string returnString = "";

            for (int i = 0; i < shortString.Length; i++)
            {
                int index = longString.IndexOf(shortString.Substring(0, shortString.Length - i));
                if (index == 0)
                {
                    return shortString.Substring(0, shortString.Length - i);
                }
            }
            return returnString;
        }

    }


    public class Leet15
    {
        public static List<IList<int>> ThreeSum(int[] nums)
        {
            List<IList<int>> list = new List<IList<int>>();
            if (nums.Length < 3)
                return list;
            Array.Sort(nums);
            HashSet<int> hash = new HashSet<int>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0)
                    break;
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
                {
                    int front = i + 1, back = nums.Length - 1, reverseSum = -1 * nums[i];
                    while (front < back)
                    {
                        if (nums[front] + nums[back] == reverseSum)
                        {
                            list.Add(new List<int>() { nums[i], nums[front], nums[back] });
                            while (front < back && nums[front] == nums[front + 1]) front++;
                            while (front < back && nums[back] == nums[back - 1]) back--;
                            front++; back--;
                        }
                        else if (nums[front] + nums[back] < reverseSum) front++;
                        else back--;
                    }
                }
            }

            return list;
        }
    }

    public class Leet16
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            int returnval = nums[1] + nums[2] + nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                int front = i + 1, back = nums.Length - 1;
                int sumClose = nums[1] + nums[2] + nums[0];

                while (front < back)
                {
                    var fb = nums[i] + nums[front] + nums[back];
                    if (target == fb)
                        return target;
                    if (Math.Abs(fb - target) < Math.Abs(sumClose - target))
                    {
                        sumClose = fb;
                        if (fb > target)
                            back--;
                        else
                            front++;
                    }
                    else if (Math.Abs(fb - target) >= Math.Abs(sumClose - target))
                    {

                        if (fb > target)
                            back--;
                        else
                            front++;

                    }
                }
                returnval = Math.Abs(target - returnval) > Math.Abs(target - sumClose) ? sumClose : returnval;
            }

            return returnval;
        }
    }

    public class Leet17
    {
        public static IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, List<string>> numCharMap = new Dictionary<char, List<string>>(){
                 {'1', new List<string>()},
                 {'2',new List<string>{"a","b","c"}},
                 {'3',new List<string>{"d","e","f"}}
                ,{'4',new List<string>{"g","h","i"}}
                ,{'5',new List<string>{"j","k","l"}}
                ,{'6',new List<string>{"m","n","o"}}
                ,{'7',new List<string>{"p","q","r","s"}}
                ,{'8',new List<string>{"t","u","v"}}
                ,{'9',new List<string>{"w","x","y","z"}}
                ,{'0',new List<string>{" "}}


            };
            var returnList = new List<string>();
            if (digits.Length == 0)
                return returnList;
            returnList.AddRange(numCharMap[digits[digits.Length - 1]]);
            for (int i = digits.Length - 2; i >= 0; i--)
            {
                var tempList = new List<string>();

                foreach (string c in numCharMap[digits[i]])
                {
                    for (int j = 0; j < returnList.Count; j++)
                    {
                        tempList.Add(c + returnList[j]);
                    }
                }
                returnList = tempList;

            }
            return returnList;

        }
    }

}