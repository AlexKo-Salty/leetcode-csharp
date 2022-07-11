public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i=0; i< nums.Length; i++)
            {
                for (int j=0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        int[] result = new int[] { i, j } ;
                        return result;
                    }
                }
            }
        
        return null;
    }

    public int[] TwoSumWithHashMap(int[] nums, int target) {
        Dictionary<int, int> Hashmap = new Dictionary<int, int>();
        for (int i=0; i< nums.Length; i++)
            {
                int diff = target - nums[i];
                if (Hashmap.ContainsValue(diff))
                {
                    int[] result = new int[] {Hashmap.FirstOrDefault(x => x.Value == diff).Key, i } ;
                    return result;
                }
                else
                {
                    Hashmap.Add(i, nums[i]);
                }
            }
        
        return null;
    }
}