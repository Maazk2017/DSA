using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion_Intermediate
{
    internal class Questions
    {
        public int UniquePaths(int m, int n)
        {
            if (m == 1 || n == 1) return 1;
            return UniquePaths(m - 1, n) + UniquePaths(m, n - 1);
            //return paths(0, 0, m - 1, n - 1);
        }

        public int paths(int cr, int cc, int lr, int lc)
        {
            if (cc == lc || cr == lr) return 1;
            if (cc > lc || cr > lr) return 0;
            int right = paths(cr, cc + 1, lr, lc);
            int left = paths(cr + 1, cc, lr, lc);
            return right + left;
        }

        public void recPrint(int[] arr, int idx)
        {
            if (idx == arr.Length) return;
            Console.Write(arr[idx] + " ");
            recPrint(arr, idx + 1);
        }

        public Boolean exists(int[] arr, int ele, int idx)
        {
            if (arr[idx] == ele) return true;
            if (idx == arr.Length) return false;
            return exists(arr, ele, idx + 1);
        }

        public int helper(int[] nums, int target, int lo, int hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (lo > hi) return -1;
            if (nums[mid] > target)
            {
                hi = mid - 1;
                return helper(nums, target, lo, hi);
            }
            else if (nums[mid] < target)
            {
                lo = mid + 1;
                return helper(nums, target, lo, hi);
            }
            else
            {
                return mid;
            }
        }
        public int Search(int[] nums, int target)
        {
            return helper(nums, target, 0, nums.Length - 1);
        }

        private void PowerSetHelper(string ans, string s, int idx, List<string> list)
        {
            if (idx == s.Length)
            {
                list.Add(ans);
                return;
            }

            PowerSetHelper(ans, s, idx + 1, list);

            PowerSetHelper(ans + s[idx], s, idx + 1, list);
        }

        public List<string> powerSet(string s)
        {
            List<string> list = new List<string>();
            PowerSetHelper("", s, 0, list);
            return list;
        }

    }
}
