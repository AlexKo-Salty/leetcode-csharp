public class Solution
{
    //Binary Search Solution
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = BinarySearch(numbers, target);

        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
                return new int[] { left + 1, right + 1 };
            else if (numbers[left] + numbers[right] > target)
                right--;
            else
                left++;
        }

        return null;
    }

    public int BinarySearch(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            int mid = (left + right) / 2;
            if (target < numbers[mid])
            {
                return mid;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }

    //Two pt only
    //public int[] TwoSum(int[] numbers, int target)
    //{
    //    int left = 0;
    //    int right = numbers.Length - 1;

    //    while (left < right)
    //    {
    //        if (numbers[left] + numbers[right] == target)
    //            return new int[] { left + 1, right + 1 };
    //        else if (numbers[left] + numbers[right] > target)
    //            right--;
    //        else
    //            left++;
    //    }

    //    return null;
    //}
}