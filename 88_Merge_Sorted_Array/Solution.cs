public class Solution {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] numsRef = (int[])nums1.Clone();
            int num1Index = 0; 
            int num2Index = 0;
            int resultIndex = 0;
            if (n != 0)
            {
                while (num2Index <= n - 1)
                {
                    if (numsRef[num1Index] > nums2[num2Index] || m == num1Index)
                    {
                        nums1[resultIndex] = nums2[num2Index];
                        num2Index++;
                        resultIndex++;
                    }
                    else
                    {
                        nums1[resultIndex] = numsRef[num1Index];
                        num1Index++;
                        resultIndex++;
                    }
                }

                //Added back all number
                for (int i = num1Index; i <= m - 1; i++)
                {
                    nums1[resultIndex] = numsRef[i];
                    resultIndex++;
                }
            }
        }
}