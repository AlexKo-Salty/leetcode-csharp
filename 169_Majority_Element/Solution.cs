public class Solution {
    public int MajorityElement(int[] arr) {
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

            return countMap.Aggregate((x,y) => x.Value > y.Value ? x:y).Key;
        }
}