public class Solution
{
    public int UniqueMorseRepresentations(string[] words)
    {
        int result = 0;
        if (words.Length == 0)
            return result;

        string[] morse = new string[]
        {
                ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
        };

        HashSet<string> pattern = new HashSet<string>();
        for (int i = 0; i < words.Length; i++)
        {
            string p = "";
            for (int j = 0; j < words[i].Length; j++)
            {
                p += morse[words[i][j] - 97];
            }
            pattern.Add(p);
        }


        return pattern.Count;
    }
}