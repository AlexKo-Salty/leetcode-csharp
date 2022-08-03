public class Solution
{
    public bool IsPalindrome(int x)
    {
        string stringx = x.ToString();
        int left = 0;
        int right = stringx.Length - 1;
        while (left < right)
        {
            if (stringx[left] != stringx[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}