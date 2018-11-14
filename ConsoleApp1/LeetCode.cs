using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/two-sum/  
namespace ConsoleApp1
{
    class LeetCode
    {

        public LeetCode()
        {
            Solution1 s = new Solution1();
            Console.WriteLine("Result : (" + s.Convert("PAYPALISHIRING" ,3) + ")");
            s = new Solution1();
            Console.WriteLine("Result : (" + s.Convert("PAYPALISHIRING", 4) + ")");
            s = new Solution1();
            Console.WriteLine("Result : (" + s.Convert("PAYPALISHIRING", 1) + ")");

            Solution2 s2 = new Solution2();
            Console.WriteLine("Result : " + s2.Reverse (-123));
            s2 = new Solution2();
            Console.WriteLine("Result : " + s2.Reverse(56789));
            s2 = new Solution2();
            Console.WriteLine("Result : " + s2.Reverse(120));
            s2 = new Solution2();
            Console.WriteLine("Result : " + s2.Reverse(1534236469)); //this output is wrong, but i don't know why

            Solution3 s3 = new Solution3();
            Console.WriteLine("Result : " + s3.LongestPalindrome("babad"));
            Console.WriteLine("Result : " + s3.LongestPalindrome("a"));
            Console.WriteLine("Result : " + s3.LongestPalindrome("cbbd"));

        }

    }

    /*
     * 

P   A   H   N
A P L S I I G
Y   I   R        
Example 1:

Input: s = "PAYPALISHIRING", numRows = 3
Output: "PAHNAPLSIIGYIR"

Example 2:

Input: s = "PAYPALISHIRING", numRows = 4
Output: "PINALSIGYAHRPI"
Explanation:

P     I    N
A   L S  I G
Y A   H R
P     I
     */
    public class Solution1
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1) return s;

            string output = string.Empty;

            for (int i = 0; i <= numRows-1; i++)
            {
                output += "/";
               int rem = s.Length % numRows;
                for (int j = 0; j < s.Length; j++)
                {
                     
                    int no = rem * (numRows - 1);
                    if (i == 0 || i == numRows - 1)
                    {
                        if  (j % no == i)   
                        {
                            output += s.Substring(j, 1);
                        }
                    }
                    else
                    {
                        
                        if  (j % no == i) 
                        {
                            output += s.Substring(j, 1);
                        }
                        else
                        {
                            if (j % no == (no - i))
                            {
                                output += s.Substring(j, 1);
                            }
                        }
                    }
                }
            }
            return output;
        }
    }


    public class Solution2
    {
        public int Reverse(int x)
        {
            int remd = 0;
            int rev = 0;
            bool IsNegivate = false;
            int checkInt =x;
            if(checkInt == (int)x)
            {
                Console.WriteLine(x + " is Integer");
            } else
            {
                Console.WriteLine(x + " is not Integer");
            }
            if (x<0)
            {
                IsNegivate = true;
                x = x * -1;
            }
            while (x > 0)
            {
                remd = x % 10;
                rev = (rev * 10) + remd;
                x = x / 10;
            }
            if (IsNegivate)
            {
                rev = rev * -1;
            }
            return rev;
        }
    }
    /*
     * Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.

    Example 1:

    Input: "babad"
    Output: "bab"
    Note: "aba" is also a valid answer.
    Example 2:

    Input: "cbbd"
    Output: "bb"
     * 
     */
    public class Solution3
    {
        public string LongestPalindrome(string s)
        {

            string pStr = string.Empty;
            int starPos = s.Length - 1;

            if (starPos == 0) return s;

            for (int i = starPos; i >= 0; i--)
            {
                pStr += s.Substring(i, 1);

            }

            string oStr = string.Empty;

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (pStr[i] == s[i])
                {
                    oStr += s[i];
                }
            }
            return oStr;
        }
    }

}
