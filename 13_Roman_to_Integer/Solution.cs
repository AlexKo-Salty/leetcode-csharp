public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("I", 1);
        dict.Add("V", 5);
        dict.Add("X", 10);
        dict.Add("L", 50);
        dict.Add("C", 100);
        dict.Add("D", 500);
        dict.Add("M", 1000);
        dict.Add("IV", 4);
        dict.Add("IX", 10);
        dict.Add("XL", 40);
        dict.Add("XC", 90);
        dict.Add("CD", 400);
        dict.Add("CM", 900);

        int result = 0;
        if (string.IsNullOrEmpty(s))
            return result;

        for (int i = 0; i < s.Length; i++)
        {
            string roman = new string(new char[] { s[i] });
            if (i != s.Length - 1)
            {
                string twoRoman = new string(new char[] { s[i], s[i + 1] });
                if (dict.ContainsKey(twoRoman))
                {
                    result += dict[twoRoman];
                    i = i + 1;
                    continue;
                }
            }
            if (dict.ContainsKey(roman))
                result += dict[roman];
        }

        return result;
    }
}