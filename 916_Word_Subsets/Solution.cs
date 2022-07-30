public class Solution {
        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            List<string> result = new List<string>();
            if (words2.Length == 0)
                return result;

            Dictionary<char, int> maxChar = new Dictionary<char, int>();

            for (int p = 0; p < words2.Length; p++)
            {
                Dictionary<char, int> word2Char = new Dictionary<char, int>();
                foreach(char c in words2[p])
                {
                    if (word2Char.ContainsKey(c))
                        word2Char[c]++;
                    else
                        word2Char.Add(c, 1);
                }
                
                foreach(var count in word2Char)
                {
                    if (!maxChar.ContainsKey(count.Key))
                    {
                        maxChar[count.Key] = count.Value;
                    }
                    else if (count.Value > maxChar[count.Key])
                    {
                        maxChar[count.Key] = count.Value;
                    }
                }
            }

            for (int i = 0; i < words1.Length; i++)
            {
                bool flag = true;
                Dictionary<char, int> word1Char = new Dictionary<char, int>();
                char[] c1 = words1[i].ToCharArray();
                foreach (char c in c1)
                {
                    if (word1Char.ContainsKey(c))
                        word1Char[c]++;
                    else
                        word1Char.Add(c, 1);
                }

                foreach (var count in maxChar)
                {
                    if (!word1Char.ContainsKey(count.Key) || word1Char[count.Key] < count.Value)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    result.Add(words1[i]);
                }
            }

            return result;
        }
}