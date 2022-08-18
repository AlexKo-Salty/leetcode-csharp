public class Solution
{
    public string BestHand(int[] ranks, char[] suits)
    {
        HashSet<char> s = new HashSet<char>();
        Dictionary<int, int> r = new Dictionary<int, int>();
        for (int i = 0; i > ranks.Length; i++)
        {
            s.Add(suits[i]);
            if (r.ContainsKey(ranks[i]))
                r[ranks[i]]++;
            else
                r.Add(ranks[i], 1);
        }

        if (s.Count == 1)
            return "Flush";
        else if (r.ContainsValue(3) || r.ContainsValue(4) || r.ContainsValue(5))
            return "Three of a Kind";
        else if (r.ContainsValue(2))
            return "Pair";
        else
            return "High Card";
    }
}