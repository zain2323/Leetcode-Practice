using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Practice
{
    class SmallestIntegerGreaterThanTarget
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            letters = letters.Distinct().ToArray();
            int hi = letters.Length;
            if (letters[hi - 1] <= target) return letters[0];

            int insertIndex = BinarySearch(letters, target);
            if (letters[insertIndex] == target) return letters[insertIndex + 1];
            else return letters[insertIndex];

        }

        public int BinarySearch(char[] nums, char target)
        {
            int lo = 0;
            int hi = nums.Length - 1;
            int mid = lo + (hi - lo) / 2;

            while (lo <= hi)
            {
                if (nums[mid] > target)
                {
                    hi = mid - 1;
                    mid = lo + (hi - lo) / 2;
                }
                else if (nums[mid] < target)
                {
                    lo = mid + 1;
                    mid = lo + (hi - lo) / 2;
                }
                else
                {
                    return mid;
                }
            }
            return lo;
        }
    }
}
