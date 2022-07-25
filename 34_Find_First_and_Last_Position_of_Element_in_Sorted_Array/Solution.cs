public class Solution
        {
            public int[] SearchRange(int[] nums, int target)
            {
                int left = 0;
                int right = nums.Length - 1;
                int mid = -1;
                int[] result = new int[2] { -1, -1 };
                if (nums.Length == 0)
                {
                    return result;
                }
                
                //Peform Binary Search
                while (left <= right)
                {
                    mid = (left + right) / 2;
                    if (nums[mid] == target)
                    {
                        int start = mid;
                        int end = mid;
                        while (start > 0 && nums[start - 1] == target)
                        {
                            start--;
                        }
                        while (end < nums.Length - 1 && nums[end + 1] == target)
                        {
                            end++;
                        }
                        result[0] = start;
                        result[1] = end;
                        break;
                    }
                    if (nums[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

                return result;
            }
        }