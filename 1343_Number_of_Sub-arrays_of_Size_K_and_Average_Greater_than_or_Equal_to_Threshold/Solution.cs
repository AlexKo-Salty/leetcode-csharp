public class Solution
{
    public int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        int start = 0;
        double sum = 0;
        int result = 0;
        for (int end = 0; end < arr.Length; end++)
        {
            sum += arr[end];
            if (end > k - 1)
            {
                if (sum / k >= threshold)
                    result++;
                sum -= arr[start];
                start++;
            }
        }
        return result;
    }
}