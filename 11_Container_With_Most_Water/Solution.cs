public class Solution
{
    //Faster, since we dont need to loop all height twice
    public int MaxArea(int[] height)
    {
        int maxArea = 0;

        int left = 0;
        int right = height.Length - 1;
        while (left < right)
        {
            int area = Math.Min(height[left], height[right]) * (right - left);
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
    //public int MaxArea(int[] height)
    //{
    //    int max = -1;
    //    int minHeight = -1;

    //    for (int i = 0; i < height.Length - 1; i++)
    //    {
    //        if (height[i] < minHeight)
    //        {
    //            continue;
    //        }
    //        for (int j = height.Length - 1; i < j; j--)
    //        {
    //            if (height[j] < minHeight)
    //            {
    //                continue;
    //            }
    //            else
    //            {
    //                int totalHeight = height[j] < height[i] ? height[j] : height[i];
    //                if (max < totalHeight * (j - i))
    //                {
    //                    minHeight = totalHeight;
    //                    max = totalHeight * (j - i);
    //                }
    //            }
    //        }
    //    }
    //    return max;
    //}
}