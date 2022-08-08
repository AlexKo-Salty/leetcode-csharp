public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 0)
            return 0;
        int max = int.MinValue;
        int startIndex = 0;
        Dictionary<int, char> vs = new Dictionary<int, char>();
        vs.Add(0, s[0]);

        for (int i = 1; i < s.Length; i++)
        {
            if (vs.ContainsValue(s[i]))
            {
                max = vs.Count > max ? vs.Count : max;
                bool RemoveDuplicate = false;
                while (!RemoveDuplicate)
                {
                    if (vs[startIndex] == s[i])
                        RemoveDuplicate = true;
                    vs.Remove(startIndex);
                    startIndex++;
                }
            }
            vs.Add(i, s[i]);
        }

        return vs.Count > max ? vs.Count : max;
    }
}