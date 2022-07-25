            public int Search(int[] nums, int target)
            {
                int result = -1;
                int left = 0;
                int mid = -1;
                int right = nums.Length - 1;

                if (right == 0)
                {
                    return nums[0] == target ? 0 : -1;
                }
                while (left <= right)
                {
                    mid = (left + right) / 2;
                    if (nums[mid] == target)
                    {
                        return mid;
                    }

                    //Step 1. Decide which part of sorted array we are
                    if (nums[mid] >= nums[left])
                    {
                        //Left Side Array Logic:
                        // 4,5,6,7,0,1,2 Let's say mid = 6 & target = 7, 1 and 4
                        // 1st Case: Target > mid, Since left < mid and they are sorted, push the left side to mid + 1 
                        //if (target > nums[mid])
                        //{
                        //    left = mid + 1;
                        //}
                        // 2nd Case: Target < nums[left], then it should be on the right side, push the left side to mid + 1 
                        //if (target < nums[left])
                        //{
                        //    left = mid + 1;
                        //}
                        // 3rd Case: nums[left] <= Target < mid, then just pull the right since the left array is sorted.
                        //if (target < nums[mid] &&  target >= nums[left])
                        //{
                        //    right + mid - 1;
                        //}
                        //1st & 2nd case are both doing same action, so combine them.
                        //Why else? Since case 1 & 2 will conflict case 3.
                        if (target < nums[mid] && target >= nums[left])
                        {
                            right = mid - 1;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }
                    else
                    {
                        //Right Side Array Logic
                        // 4,5,6,7,0,1,2 Let's say mid = 1 & target = 5, 0 and 2
                        // 1st Case: Target > mid && Target > nums[right], then the num should be rotated to left side. Pull the right side
                        //if (target > nums[mid] && target > nums[right])
                        //{
                        //    right = mid - 1;
                        //}
                        // 2nd Case: Target < nums[mid], then it should be on the left side since the left side is smaller than mid.
                        //if (target < nums[right])
                        //{
                        //    right = mid - 1;
                        //}
                        // 3rd Case: nums[right] > target > mid, then just pull the right since the right array is sorted and contains the target value.
                        //if (target > nums[mid] &&  target <= nums[right])
                        //{
                        //    left = mid + 1;
                        //}
                        //1st & 2nd case are both doing same action, so combine them.
                        //Why else? Since case 1 & 2 will conflict case 3.
                        if (target > nums[mid] && target <= nums[right])
                        {
                            left = mid + 1;
                        }
                        else
                        {
                            right = mid - 1;
                        }
                    }
                }

                return result;
            }
        }