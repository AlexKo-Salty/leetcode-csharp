public bool IsIsomorphic(string s, string t)
{
    Dictionary<char, char> sdict = new Dictionary<char, char>();
    Dictionary<char, char> tdict = new Dictionary<char, char>();
    for (int i = 0; i < s.Length; i++)
    {
        if (sdict.ContainsKey(s[i]))
        {
            if (t[i] != sdict[s[i]])
                return false;
        }
        else
        {
            sdict.Add(t[i], s[i]);
        }

        if (tdict.ContainsKey(t[i]))
        {
            if (s[i] != tdict[t[i]])
                return false;
        }
        else
        {
            tdict.Add(t[i], s[i]);
        }
    }

    return true;
}