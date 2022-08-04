public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int i = 1;
        while (i < n)
        {
            int mid = (i) + (n - i) / 2;
            if (IsBadVersion(mid))
            {
                n = mid;
            }
            else
            {
                i = mid + 1;
            }
        }

        return i;
    }
}