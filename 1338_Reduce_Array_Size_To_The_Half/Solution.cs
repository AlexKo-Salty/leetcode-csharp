public class Solution
{
    public int MinSetSize(int[] arr)
    {
        int target = arr.Length / 2;
        int curr = arr.Length;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (dict.ContainsKey(arr[i]))
                dict[arr[i]]++;
            else
                dict.Add(arr[i], 1);
        }

        int[] count = dict.Values.ToArray();
        Array.Sort(count);
        Array.Reverse(count);

        int result = 0;
        while (curr > target)
        {
            curr = curr - count[result];
            result++;
        }

        return result;
    }
}