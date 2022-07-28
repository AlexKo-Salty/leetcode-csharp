        public class Solution
        {
            public int[] ProductExceptSelf(int[] nums)
            {
                int[] result = new int[nums.Length];
                //Since the result = nums[0...n] / num[i].
                int prod = 1;
                bool hasZero = false;
                bool hasMoreThanOneZero = false;
                foreach (int value in nums)
                {
                    if (value != 0)
                        prod *= value;
                    else
                    {
                        if (!hasZero)
                            hasZero = true;
                        else if (!hasMoreThanOneZero)
                            hasMoreThanOneZero = true;
                    }    

                }

                for (int i = 0; i < nums.Length; i++)
                {
                    if (hasMoreThanOneZero)
                        nums[i] = 0;
                    else if (hasZero && nums[i] != 0)
                        nums[i] = 0;
                    else if (hasZero && nums[i] == 0)
                        nums[i] = prod;
                    else
                        nums[i] = prod / nums[i];
                }
                return nums;
            }