public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        char[] sort = s1.ToCharArray();
        Array.Sort(sort);
        string target = new string(sort);

        int left = 0;

        while (s2.Length - left >= s1.Length)
        {
            if (!target.Contains(s2[left]))
            {
                left++;
                continue;
            }
            else
            {
                string check = s2.Substring(left, s1.Length);
                char[] checkSort = check.ToCharArray();
                Array.Sort(checkSort);
                string sortedCheck = new string(checkSort);

                if (sortedCheck == target)
                    return true;
                else
                    left++;
            }

        }

        return false;
    }

    /*Better Solution, Using Two Hashmap to crosscheck       
      siding window as after first go through s1.count();
      remove first key and add the s1.Count + 1.
    */
    //public bool CheckInclusion(string s1, string s2)
    //{

    //    if (s1.Length > s2.Length) return false;

    //    var dict = new Dictionary<char, int>();
    //    var dict2 = new Dictionary<char, int>();

    //    for (int i = 0; i < s1.Length; i++)
    //    {
    //        if (!dict.ContainsKey(s1[i]))
    //        {
    //            dict.Add(s1[i], 1);
    //        }
    //        else
    //        {
    //            dict[s1[i]]++;
    //        }

    //        if (!dict2.ContainsKey(s2[i]))
    //        {
    //            dict2.Add(s2[i], 1);
    //        }
    //        else
    //        {
    //            dict2[s2[i]]++;
    //        }
    //    }

    //    if (Found(ref dict, ref dict2)) return true;

    //    int r = 0;
    //    int to = s2.Length - 1;
    //    while (s1.Length + r <= to)
    //    {

    //        var key = s2[r];
    //        if (dict2[key] > 1) dict2[key]--;
    //        else dict2.Remove(key);

    //        key = s2[s1.Length + r];
    //        if (!dict2.ContainsKey(key))
    //        {
    //            dict2.Add(key, 1);
    //        }
    //        else
    //        {
    //            dict2[key]++;
    //        }

    //        if (Found(ref dict, ref dict2)) return true;

    //        r++;
    //    }
    //    return false;

    //}

    //private bool Found(ref Dictionary<char, int> dict, ref Dictionary<char, int> dict2)
    //{
    //    foreach (var d in dict)
    //    {
    //        if (!dict2.ContainsKey(d.Key)) return false;
    //        if (dict2[d.Key] != d.Value) return false;
    //    }
    //    return true;
    //}
}