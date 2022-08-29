public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Stack<(int temp, int index)> vs = new Stack<(int temp, int index)>();

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (vs.Count != 0 && vs.Peek().temp < temperatures[i])
            {
                (int temp, int index) lower = vs.Pop();
                result[lower.index] = i - lower.index;
            }
            vs.Push((temperatures[i], i));
        }

        return result;
    }
}