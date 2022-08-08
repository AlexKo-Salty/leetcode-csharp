public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string common = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            if (common == strs[i])
                continue;
            else
            {
                int j = 0;
                while (j < common.Length && j < strs[i].Length && common[j] == strs[i][j])
                {
                    j++;
                }

                if (j == 0)
                {
                    return "";
                }
                common = common.Substring(0, j);
            }
        }

        return common;
    }
}