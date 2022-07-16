    public class Solution
    {
        public int FindLucky(int[] arr)
        {
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (countMap.ContainsKey(num))
                {
                    countMap[num]++;
                }
                else
                {
                    countMap.Add(num, 1);
                }
            }

            if (countMap.Any(c => c.Key == c.Value))
            {
                return countMap.Where(c => c.Key == c.Value).Max(c => c.Value);
            }
            else
            {
                return -1;
            }           
        }
    }