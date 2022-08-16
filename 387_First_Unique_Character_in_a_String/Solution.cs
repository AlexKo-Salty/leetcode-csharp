public class Solution
{
    public int FirstUniqChar(string s)
    {
        if (string.IsNullOrEmpty(s))
            return -1;

        HashSet<char> dict = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.Add(s[i]))
                continue;
            else
            {
                string ss = s.Substring(i == 0 ? 0 : i - 1);
                if (!ss.Contains(s[i]))
                    return i;
            }
        }

        return -1;
    }
}