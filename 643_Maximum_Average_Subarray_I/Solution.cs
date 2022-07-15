public class Solution {
        public double FindMaxAverage(int[] nums, int k)
        {
            double maxvalue = double.MinValue;
            double currentSumValue = 0;
            for (int i = 0; i < nums.Length; i ++)
            {
                currentSumValue += nums[i];
                //Check the sum while the summary is sum up of 4 elements
                if (i >= k -1)
                {
                    maxvalue = Math.Max(currentSumValue, maxvalue);
                    //After compare, remove unnessary first element for next loop
                    currentSumValue -= nums[i - (k - 1)];
                }
            }

            return Math.Round(maxvalue / k , 5);
        }
}