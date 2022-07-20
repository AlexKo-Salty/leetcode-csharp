    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            int refIndex = 0;
            int wordIndex = 0;
            while (refIndex < t.Length && wordIndex < s.Length)
            {
                if (t[refIndex] == s[wordIndex])
                {
                    wordIndex++;
                }
                refIndex++;
            }

            return s.Length == wordIndex;
        }
    }