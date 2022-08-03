public class MyCalendar
{

    List<int[]> slot = new List<int[]>();

    public MyCalendar()
    {

    }

    public bool Book(int start, int end)
    {
        if (slot == null || slot.Count == 0)
        {
            slot = new List<int[]>();
            slot.Add(new int[] { start, end });
            return true;
        }
        else if ((end <= slot[0][0] && start <= slot[0][0]) || (start >= slot[slot.Count - 1][1]))
        {
            slot.Add(new int[] { start, end });
            slot.Sort((x, y) => x[0].CompareTo(y[0]));
            return true;
        }
        else
        {
            //Using Binary Search, Get the closest slot
            int startIndex = BinarySearch(start, slot);
            startIndex = startIndex == 0 ? startIndex : startIndex - 1;
            int next = startIndex == slot.Count() - 1 ? startIndex : startIndex + 1;
            if ((start >= slot[startIndex][1] && end <= slot[next][0]))
            {
                slot.Add(new int[] { start, end });
                slot.Sort((x, y) => x[0].CompareTo(y[0]));
                return true;
            }
            return false;
        }
    }

    public int BinarySearch(int start, List<int[]> slots)
    {
        int left = 0;
        int right = slots.Count - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (start == slot[mid][0])
                return mid + 1;
            else if (start < slot[mid][0])
                right = mid - 1;
            else
                left = mid + 1;
        }

        return left;
    }
}

/**
 * Your MyCalendar object will be instantiated and called as such:
 * MyCalendar obj = new MyCalendar();
 * bool param_1 = obj.Book(start,end);
 */