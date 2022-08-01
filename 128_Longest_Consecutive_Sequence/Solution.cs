public class Solution {
    public int LongestConsecutive(int[] nums) {
                if (nums.Length == 0)
                    return 0;

                int longest = 0;
                int combo = 0;
                Array.Sort(nums);
                int prevNum = nums[0];
                for (int i = 1; i < nums.Length; i++)
                {
                    if (prevNum + 1 == nums[i])
                    {
                        combo++;
                    }
                    else if (prevNum == nums[i])
                    {
                        continue;
                    }
                    else
                    {
                        if (longest < combo)
                            longest = combo;
                        combo = 0;
                    }

                    prevNum = nums[i];
                }

                if (longest < combo)
                    longest = combo;
                return longest + 1;
    }
}