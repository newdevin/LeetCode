using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class TwoSum
    {
        public static int[] SumOf2(int[]nums, int target)
        {
            var cache = new Dictionary<int, List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(!cache.ContainsKey(nums[i]))
                    cache.Add(nums[i], new List<int> { i });
                else
                    cache[nums[i]].Add(i);
            }
            for (int i = 0; i < nums.Length; i++)
            {
                var numRequired = target - nums[i];
                if(cache.ContainsKey(numRequired))
                {
                    var found = cache[numRequired].Where(idx => idx != i);
                    if(found?.Count() > 0)
                    {
                        return new int[] {i, found.First()};
                    }
                }
            }
            return System.Array.Empty<int>();
        }
    }
}
