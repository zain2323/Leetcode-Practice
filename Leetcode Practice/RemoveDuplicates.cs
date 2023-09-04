public class ContainsDuplicateProblem
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> distinctNumbers = new HashSet<int>(nums);
        return distinctNumbers.Count != nums.Length;
    }
}