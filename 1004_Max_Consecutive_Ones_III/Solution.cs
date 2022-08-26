public class Solution
{
    public int LongestOnes(int[] nums, int k)
    {
        int max = int.MinValue;
        int start = 0;
        int[] vs = new int[2];
        for (int end = 0; end < nums.Length; end++)
        {
            vs[nums[end]]++;
            while (vs[0] > k)
            {
                vs[nums[start]]--;
                start++;
            }
            if (end - start + 1 > max)
                max = end - start + 1;
        }

        return max;
    }
}