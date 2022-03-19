using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class SortedArraysMedian
    {
        public static double Median(int[] nums1, int[] nums2)
        {
            var len = nums1.Length + nums2.Length;
            var midIndex = (int)(len / 2);
            var mid1Index = midIndex - 1;
            var midValue = -1;
            var mid1Value = -1;
            int curr = 0;
            int cur1 = 0;
            int cur2 = 0;
            var midValueFound = false;
            var mid1ValueFound = false;
            while (cur1 < nums1.Length && cur2 < nums2.Length)
            {
                if (nums1[cur1] < nums2[cur2])
                {
                    if (curr == midIndex)
                    {
                        midValue = nums1[cur1];
                        midValueFound = true;
                    }
                    if (curr == mid1Index)
                    {
                        mid1Value = nums1[cur1];
                        mid1ValueFound = true;
                    }

                    cur1 += 1;
                }
                else
                {
                    if (curr == midIndex)
                    {
                        midValue = nums2[cur2];
                        midValueFound = true;
                    }
                    if (curr == mid1Index)
                    {
                        mid1Value = nums2[cur2];
                        mid1ValueFound = true;
                    }
                    cur2 += 1;
                }

                curr += 1;

                if (midValueFound && mid1ValueFound)
                    break;
            }
            while (cur1 < nums1.Length && (midValueFound == false || mid1ValueFound == false))
            {
                if (curr == midIndex)
                {
                    midValue = nums1[cur1];
                    midValueFound = true;
                }
                if (curr == mid1Index)
                {
                    mid1Value = nums1[cur1];
                    mid1ValueFound = true;
                }
                curr++;
                cur1++;
            }
            while (cur2 < nums2.Length && (midValueFound == false || mid1ValueFound == false))
            {
                if (curr == midIndex)
                {
                    midValue = nums2[cur2];
                    midValueFound = true;
                }
                if (curr == mid1Index)
                {
                    mid1Value = nums2[cur2];
                    mid1ValueFound = true;
                }
                cur2++;
                curr++;
            }

            if (len % 2 != 0)
            {
                return midValue;
            }
            else
            {
                var num1 = midValue;
                var num2 = mid1Value;
                var avg = (num1 + num2) / 2.0;
                return avg;
            }
        }
    }
}
