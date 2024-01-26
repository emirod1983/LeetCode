using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._0001_0050
{
    public class _01_TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j]  == target) return new int[] { i, j };
                }
            }

            return new int[] { };
        }

        // Alternative solution using Dictionary
        public int[] TwoSum_Dict(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                    return new int[] { dic[nums[i]], i };
                else
                    dic[target - nums[i]] = i;
            }

            return new int[] { };
        }
    }
}
