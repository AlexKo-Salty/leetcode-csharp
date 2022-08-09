public bool HalvesAreAlike(string s)
{
    if (string.IsNullOrEmpty(s) || s.Length == 0)
        return false;

    s = s.ToLower();
    //Book 01 23
    //Length = 4; mid = 4/2 = 2, - 1 by index
    int midIndex = (s.Length / 2);
    string left = s.Substring(0, s.Length / 2);
    string right = s.Substring(midIndex, s.Length / 2);
    char[] v = new char[5] { 'a', 'e', 'i', 'o', 'u' };
    int leftv = 0;
    int rightv = 0;

    for (int i = 0; i < left.Length; i++)
    {
        if (v.Contains(left[i]))
            leftv++;
        if (v.Contains(right[i]))
            rightv++;
    }

    return leftv == rightv;
}