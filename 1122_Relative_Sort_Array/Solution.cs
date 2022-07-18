    public class Solution
    {
        public int[] RelativeSortArray(int[] arr1, int[] arr2)
        {
            List<int> result = new List<int>();
            result.AddRange(arr1);
            result.Sort();
            Dictionary<int, int> sortHashMap = new Dictionary<int, int>();
            for (int i = 0; i < arr2.Length; i++)
            {
                sortHashMap.Add(arr2[i], i);
            }

            return result.OrderBy(o =>
            {
                if (sortHashMap.ContainsKey(o))
                {
                    return sortHashMap[o];
                }
                else
                {
                    return Int32.MaxValue;
                }
            }).ToArray();
        }
    }