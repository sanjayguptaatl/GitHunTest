using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingGitHub
{
    static class CodeForFun
    {
        public static string NumberInWords(int n)
        {
            string strNum = string.Empty;

            // Get the individual numbers from right to left.


            return strNum;
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000000) > 0)
            {
                words += NumberToWords(number / 1000000000) + " billion ";
                number %= 1000000000;
            }
            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }

        public static string AnagramFinder(string[] arrStrings)
        {
            string[][] arrArrayOfAnagrams = new string[arrStrings.Length][];
            string str1 = string.Empty;

            for (int i = 0; i < arrStrings.Length; i++)
            {
                for (int j = i + 1; j < arrStrings.Length - i; j++)
                {
                    if (isAnagram(arrStrings[i], arrStrings[j]))
                    {
                        //arrArrayOfAnagrams[0] = new string[] { arrStrings[i], arrStrings[j] };
                        str1 += arrStrings[i] + " " + arrStrings[j] + " ";
                        arrStrings = arrStrings.Where(c => c != arrStrings[i]).ToArray();
                        j = i = 0;
                    }
                    else
                    {
                        //arrArrayOfAnagrams[0] = new string[] { arrStrings[i] };
                        str1 += arrStrings[i];
                    }
                }
            }

            return str1;
        }

        private static bool isAnagram(string strOne, string strTwo)
        {
            if (strOne.Length != strTwo.Length)
                return false;

            char[] ArrStringOne = strOne.ToLower().ToCharArray();
            char[] ArrStringTwo = strTwo.ToLower().ToCharArray();

            Array.Sort(ArrStringOne);
            Array.Sort(ArrStringTwo);

            if ((new string(ArrStringOne)) == (new string(ArrStringTwo)))
                return true;

            return false;
        }
    }
}
//if (something)
//              return true;
//          return false;