int BinarySearch(int[] nums, int target)
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
    return -1;
}

int[] nums = { -1, 0, 3, 5, 9, 12 };
int target = 13;
int res = BinarySearch(nums, target);
Console.WriteLine(res);