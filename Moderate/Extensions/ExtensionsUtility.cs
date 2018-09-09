using System;
using System.Collections.Generic;
using System.Text;

namespace Moderate.Extensions
{
    static class ExtensionsUtility
    {
        public static string ToStringExnteded(this int number)
        {
            int indicator = 0;
            StringBuilder sb = new StringBuilder();
            while (number % 10 > 0 || number / 10 >0)
            {
                int posNum = number % 1000;
                sb.Insert(0, ThreePointString(posNum, indicator));
                indicator++;
                number = number / 1000;
            }
            return sb.ToString();
        }

        private static string GetSingleStringCap(int indicator)
        {
            if (indicator>0)
            {
                if (indicator == 1)
                    return " Thousand";
                if (indicator == 2)
                    return " Million";
                if (indicator == 3)
                    return " Billion";
                if (indicator == 4)
                    return " Trillion";
                throw new Exception("Supports only till Trillion right now");
            }
            else
                return " ";
        }

        private static string ThreePointString(int number,int indicator)
        {
            int loop = 2;
            string returnString = "";
            while (loop > 0)
            {
                int i = number / (int)Math.Pow(10,loop);
                number = number% (int)Math.Pow(10, loop);

                returnString += GetString(i, loop);
                if (number < 20 && number > 10)
                {
                    returnString += " "+NumberBetweenTenAndTwenty(number) + GetSingleStringCap(indicator);
                    return returnString;
                }
                loop--;
            }
            return returnString + GetSingleString(number) + GetSingleStringCap(indicator);
        }

        private static string GetString(int i, int loop)
        {
            if (loop == 2 && i>0)
                return GetSingleString(i) + " Hundred";
            if (loop == 1)
            {
                switch (i)
                {
                    case 1:
                        return " Ten";
                    case 2:
                        return " Twenty";
                    case 3:
                        return " Thirty";
                    case 4:
                        return " Forty";
                    case 5:
                        return " Fifty";
                    case 6:
                        return " Sixty";
                    case 7:
                        return " Seventy";
                    case 8:
                        return " Eighty";
                    case 9:
                        return " Ninty";
                    default:
                        return "";
                }
            }
            return GetSingleString(i);
        }

        private static string GetSingleString(int i)
        {
            switch (i)
            {
                case 1:
                    return " One";
                case 2:      
                    return " Two";
                case 3:      
                    return " Three";
                case 4:      
                    return " Four";
                case 5:      
                    return " Five";
                case 6:      
                    return " Six";
                case 7:      
                    return " Seven";
                case 8:      
                    return " Eight";
                case 9:      
                    return " Nine";
                default:
                    return " ";
            }
        }
        private static string NumberBetweenTenAndTwenty(int number)
        {
            switch (number)
            {
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";
                case 13:
                    return "Thirteen";
                case 14:
                    return "Fourteen";
                case 15:
                    return "Fifteen";
                case 16:
                    return "Sixteen";
                case 17:
                    return "Seventeen";
                case 18:
                    return "Eighteen";
                case 19:
                    return "Ninteen";
                default:
                    return "";
            }
        }
    }
}
