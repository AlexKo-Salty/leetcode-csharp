public class Solution {
    public int SumOfUnique(int[] nums) {
            Dictionary<int, bool> uniqueList = new Dictionary<int, bool>();
            for(int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (uniqueList.ContainsKey(nums[i]))
                {
                    uniqueList[num] = false;
                }
                else
                {
                    uniqueList.Add(num, true);
                }
            }
            int result = uniqueList.Where(e => e.Value).Sum(e => e.Key);
        return result;
    }
}