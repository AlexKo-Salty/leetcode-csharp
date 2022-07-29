        public class Solution
        {
            //Runtime: 187 ms
            //Memory Usage: 45.7 MB
            public int[] TopKFrequent(int[] nums, int k)
            {
                Dictionary<int, int> count = new Dictionary<int, int>();
                int[] result = new int[k];
                for (int i = 0; i < nums.Length; i++)
                {
                    if (count.ContainsKey(nums[i]))
                        count[nums[i]]++;
                    else
                        count.Add(nums[i], 1);
                }

                var countSorted = count.OrderByDescending(x => x.Value).ToHashSet();
                while (k > 0)
                {
                    result[k - 1] = countSorted.First().Key;
                    countSorted.Remove(countSorted.First());
                    k--;
                }

                return result;
            }
        }