public class Solution {
        /*
         * Revised Solution, Change the index(value) in dict when same number is found.
         * Reference:
         * https://leetcode.com/problems/contains-duplicate-ii/discuss/302661/C-concise-and-straightforward
         * Runtime: 203 ms
         * Memory Usage: 59.5 MB
         */
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> hasmap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if (hasmap.ContainsKey(num) && i - hasmap[num] <= k)
                {
                    return true;
                }
                hasmap[nums[i]] = i;
            }

            return false;
        }
        /*
         * Solution by me, pretty slow with below result:
         * Runtime: 2557 ms
         * Memory Usage: 49 MB
         */
        //public bool ContainsNearbyDuplicate(int[] nums, int k)
        //{
        //    Dictionary<int, int> hasmap = new Dictionary<int, int>();
        //    for (int i = 0; i < nums.Length; i ++)
        //    {
        //        int num = nums[i];
        //        if (hasmap.Count > k)
        //        {
        //            hasmap.Remove((i - k - 1));
        //        }
        //        if (hasmap.ContainsValue(num))
        //        {
        //            return true;
        //        }
        //        hasmap.Add(i, nums[i]);
        //    }

        //    return false;
        //}
}