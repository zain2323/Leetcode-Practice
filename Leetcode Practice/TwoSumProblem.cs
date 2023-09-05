public class TwoSumProblem
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }
        return result;
    }

    public int[] TwoSumHashMap(int[] nums, int target)
    {
        Dictionary<int, int> prevMap = new Dictionary<int, int>();
        int i = 0;
        foreach (var item in nums)
        {
            int diff = target - item;
            if (prevMap.ContainsKey(diff))
            {
                return new int[] { prevMap[diff], i };
            }
            prevMap[item] = i;
            i += 1;
        }
        return new int[] { -1, -1 };
    }
}