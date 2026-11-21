using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Binary_Search
{
    internal class Questions
    {
        public int binarySearch(int[] nums, int target)
        {
            int lo = 0;
            int hi = nums.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (nums[mid] > target)
                {
                    hi = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }


        public int binarySearchDesc(int[] nums, int target)
        {
            int hi = 0;
            int lo = nums.Length - 1;

            while (hi <= lo)
            {
                int mid = lo + (hi - lo) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                } else if (nums[mid] > target)
                {
                    hi = mid + 1;
                } else
                {
                    lo = mid - 1;
                }
            }

            return -1;
        }
    }
}
