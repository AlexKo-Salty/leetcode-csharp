public class Solution {
    public IList<int> MajorityElement(int[] nums) {
            double targetTimes = (nums.Length / 3);
            int currentIndex = 0;
            List<int> numList = new List<int>();
            List<int> result = new List<int>();
            numList.AddRange(nums);
            numList.Sort();
            while (currentIndex <= numList.Count - 1)
            {
                int num = numList[currentIndex];
                int count = numList.Where(x => x == num).Count();
                if (count > targetTimes)
                {
                    result.Add(num);
                }

                currentIndex += count;
            }

            return result;
    }
}