public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int maxLength = 0;
        int start = 0, maxCount = 0;
        int maxStart = 0;

        int[] count = new int[26];

        for (int end = 0; end < s.Length; end++)
        {
            count[s[end] - 'A']++;
            maxCount = Math.Max(maxCount, count[s[end] - 'A']);

            while (end - start + 1 - maxCount > k)
            {
                count[s[start] - 'A']--;
                start++;
            }

            int length = end - start + 1;
            if (length > maxLength)
            {
                maxLength = length;
                maxStart = start;
            }
        }

        // This gives substring
        // Console.WriteLine(s.Substring(maxStart, maxLength));
        return maxLength;
    }

    //Too Slow Solution
    //public int CharacterReplacement(string s, int k)
    //{
    //    if (string.IsNullOrEmpty(s) || s.Length == 0)
    //    {
    //        return 0;
    //    }

    //    int changeCount = k;
    //    int max = int.MinValue;
    //    int count = 1;
    //    char currentChar = s[0];
    //    int firstInvaildIndex = 0;

    //    for (int i = 1; i < s.Length; i++)
    //    {
    //        if (s[i] == currentChar)
    //        {
    //            count++;
    //            continue;
    //        }
    //        else
    //        {
    //            if (changeCount == k)
    //                firstInvaildIndex = i;

    //            if (changeCount > 0)
    //            {
    //                count++;
    //                changeCount--;
    //                continue;
    //            }
    //            else
    //            {
    //                max = max > count ? max : count;
    //                i = firstInvaildIndex;
    //                currentChar = s[i];
    //                count = 1;
    //                changeCount = k;
    //            }
    //        }
    //    }

    //    if (changeCount > 0 && count < s.Length)
    //        count = count + changeCount;

    //    if (count > s.Length)
    //        count = s.Length;

    //    return max > count ? max : count;
    //}
}