using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Strings
{
    public static class StringExtensions
    {
        public static int LongestSubstringWithoutRepeatingChars(this string s)
        {
            var maxLength = 0;
            var firstIndex = 0;
            var length = 0;
            var set = new HashSet<char>();
            for (int j = 0; j < s.Length; j++)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    length++;
                }
                else
                {
                    maxLength = Math.Max(length, maxLength);
                    while (s[firstIndex] != s[j])
                    {
                        set.Remove(s[firstIndex]);
                        firstIndex++;
                        length--;
                    }
                    if (s[firstIndex] == s[j])
                    {
                        set.Remove(s[firstIndex]);
                        length--;
                        firstIndex++;
                    }
                    
                    if (!set.Contains(s[j]))
                    {
                        set.Add(s[j]);
                        length++;
                    }
                }
            }
            maxLength = Math.Max(length, maxLength);

            return maxLength;

            /************old solution start***************/
            //var result = 0;
            //var set = new HashSet<char>();
            //for (int j = 0; j < s.Length; j++)
            //{
            //    if (result > s.Length / 2 && j > s.Length / 2)
            //    {
            //        return result;
            //    }
            //    int length = 0;
            //    set.Clear();
            //    set.Add(s[j]);
            //    length++;
            //    for (int i = j + 1; i < s.Length; i++)
            //    {
            //        if (!set.Contains(s[i]))
            //        {
            //            length++;
            //            set.Add(s[i]);
            //        }
            //        else
            //        {
            //            if (length > result)
            //            {
            //                result = length;
            //            }
            //            break;
            //        }
            //    }
            //    if (set.Count > 0)
            //    {
            //        if (length > result)
            //        {
            //            result = length;
            //        }
            //    }
            //}

            //return result;
            /**********old solutoin end*/
        }
    }
}
