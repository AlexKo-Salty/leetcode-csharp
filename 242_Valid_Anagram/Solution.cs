public class Solution {
            //Another Solution using char Array & Sort
            // public bool IsAnagram(string s, string t)
            // {
            //     if (s.Length != t.Length)
            //         return false;

            //     char[] sChars = s.ToCharArray();
            //     char[] tChars = t.ToCharArray();
            //     Array.Sort(tChars);
            //     Array.Sort(sChars);

            //     return (new string(sChars) == new string(tChars));
            // }

            public bool IsAnagram(string s, string t)
            {                
                if (s.Length != t.Length)
                    return false;
                Dictionary<char, int> dict = new Dictionary<char, int>(); 
                for (int i = 0; i < s.Length; i ++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        dict[s[i]]++;
                    }
                    else
                    {
                        dict.Add(s[i], 1);
                    }
                }

                for (int j = 0; j < t.Length; j++)
                {
                    if (!dict.ContainsKey(t[j]) || dict[t[j]] == 0)
                        return false;
                    else
                        dict[t[j]]--;
                }

                return true;
            }
}