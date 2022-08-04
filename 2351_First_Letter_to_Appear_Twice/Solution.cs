public class Solution
{
    public char RepeatedCharacter(string s)
    {
        HashSet<char> dict = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!dict.Add(s[i]))
                return s[i];
        }

        return '.';
    }
}