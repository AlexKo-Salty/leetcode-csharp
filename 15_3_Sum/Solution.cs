public class Solution
{

    /*
     * Better Solution, skip duplicated next value(s) to prevent duplicate result
     */
    public IList<IList<int>> ThreeSum(int[] nums)
    {

        List<IList<int>> results = new List<IList<int>>();

        Array.Sort(nums);
        int left = 0;
        int right = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {

            if (i > 0 && nums[i] == nums[i - 1]) continue; // skip dup values for i

            left = i + 1;
            right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    List<int> result = new List<int>() { nums[i], nums[left], nums[right] };
                    results.Add(result);
                    left++;
                    right--;

                    //skip dup values for left and right
                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;

                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }

            }


        }

        return results;
    }

        //public IList<IList<int>> ThreeSum(int[] nums)
        //{
        //    Array.Sort(nums);
        //    HashSet<string> checkSum = new HashSet<string>();
        //    List<int[]> result = new List<int[]>();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        int left = 0;
        //        int right = nums.Length - 1;

//        while (left < right)
//        {
//            if (i == left)
//            {
//                left++;
//                continue;
//            }
//            else if (i == right)
//            {
//                right--;
//                continue;
//            }

//            int sum = nums[left] + nums[right] + nums[i];
//            {
//                if (sum < 0)
//                {
//                    left++;
//                }
//                else if (sum > 0)
//                {
//                    right--;
//                }
//                else
//                {
//                    int[] temp = new int[] { nums[left], nums[right], nums[i] };
//                    Array.Sort(temp);
//                    if (checkSum.Add(string.Join(",", temp)))
//                        result.Add(new int[] { nums[left], nums[right], nums[i] });
//                    left++;
//                    right--;
//                }
//            }
//        }
//    }

//    return result.ToArray();
//}