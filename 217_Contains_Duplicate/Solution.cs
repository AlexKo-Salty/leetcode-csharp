public class Solution {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = nums[i];
                if(hashSet.Contains(nums[i]))
                {
                    return true;
                }
                hashSet.Add(num);
                //if (!hashSet.Add(nums[i]))
                //{
                //    return true;
                //}
            }

            return false;
        }
}