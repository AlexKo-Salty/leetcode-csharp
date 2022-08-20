public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        int result = 0;
        char start;
        char mid;
        char end;
        for (int i = 2; i < s.Length; i++)
        {
            start = s[i - 2];
            mid = s[i - 1];
            end = s[i];
            if (start == mid || mid == end || start == end)
                continue;
            else
                result++;
        }

        return result;
    }
}