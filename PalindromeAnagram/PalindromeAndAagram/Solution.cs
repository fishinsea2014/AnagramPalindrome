using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeAndAagram
{
    public class Solution
    {
        /// <summary>
        /// Evaluate a string, return three result
        /// 1. Palindrome which is Res.Palindrome
        /// 2. Exit a palindrome in the anagrams, which is Res.AnaPalindrome
        /// 3. None, neither a Palindrome nor AnaPalindrome
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Res IsPalindromeOrAnaPalidrome(string str)
        {
            //Evaluating palindrome
            if (str.Length == 1) return Res.Palindrome;
            if (IsPalindrome(str)) return Res.Palindrome;

            //Evaluating exist a palindrome in all anagrams
            if (IsAnaPalidrome(str)) return Res.AnaPalindrome;

            return Res.None;

        }

        private static bool IsAnaPalidrome(string str)
        {
            var strArr = str.ToCharArray();
            Array.Sort(strArr);
            bool isAnaPal = false;

            //If the length is even, then compare by pair, return false if one pair is not equal
            if (str.Length % 2 == 0)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (i % 2 == 1) continue;
                    if (strArr[i] != strArr[i + 1]) break;
                    if (i == str.Length - 2)
                        isAnaPal = true;
                }


            }
            //If the lenght is odd, then 
            else
            {
                //The number of single char, which is not equal to the next char
                int numOfSingle = 0;
                int i = 0;
                while (i < str.Length)
                {
                    if (i == str.Length - 1)
                    {
                        numOfSingle += 1;
                        break;
                    }
                    //If str[i] is not equal to str[i+1], then number of single char plus one and continue to compare
                    if (strArr[i] != strArr[i + 1])
                    {
                        numOfSingle += 1;
                        i += 1;
                        continue;
                    }
                    //If str[i] is equal to str[i+1], then skip str[i+1]
                    else
                    {
                        i += 2;
                        continue;
                    }
                }

                //If there is only one single char, then return true
                if (numOfSingle == 1) isAnaPal = true;
            }

            //Return false.
            return isAnaPal ;
        }

        private static bool IsPalindrome(string str)
        {
            var strArr = str.ToCharArray();
            var strArrRev = str.ToCharArray();
            Array.Reverse(strArrRev);
            if (new string(strArr) == new string(strArrRev))
                return true;
            return false;
        }
    }
}
