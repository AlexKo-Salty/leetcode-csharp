    public class Solution
    {
		public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            List<string> result = new List<string>();
            if (words.Length == 0 || pattern.Length == 0)
            {
                return result;
            }
            Dictionary<int, char> patternDict = new Dictionary<int, char>();
            for (int p = 0; p < pattern.Length; p++)
            {
                patternDict.Add(p, pattern[p]);
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (pattern.Length != words[i].Length)
                    break;
                //pattern as key, word as value
                Dictionary<char, char> dict = new Dictionary<char, char>();
                for (int j = 0; j < words[i].Length; j++)
                {
                    //Step 1: Get the current index pattern's value:
                    char currPatternValue = patternDict[j];

                    if (!dict.ContainsKey(currPatternValue))
                    {
                        if (dict.ContainsValue(words[i][j]))
                            break;
                        dict.Add(currPatternValue, words[i][j]);
                    }
                    else if (dict[currPatternValue] != words[i][j])
                        break;

                    if (j == words[i].Length - 1)
                    {
                        result.Add(words[i]);
                    }
                }
            }

            return result;
        }
	}