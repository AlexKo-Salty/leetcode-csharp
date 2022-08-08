public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        int result = 0;
        Array.Sort(g);
        Array.Sort(s);

        int childIndex = g.Length - 1;
        int cookieIndex = s.Length - 1;
        while (childIndex >= 0 && cookieIndex >= 0)
        {
            if (g[childIndex] <= s[cookieIndex])
            {
                result++;
                childIndex--;
                cookieIndex--;
            }
            else
            {
                childIndex--;
            }
        }

        return result;
    }
}