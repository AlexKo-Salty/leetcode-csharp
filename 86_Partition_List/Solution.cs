public class Solution {
    public ListNode Partition(ListNode head, int x) {
            ListNode prevLessThan = null;
            ListNode prev = null;
            ListNode curr = head;
            ListNode firstGreater = null;
            if (head == null || head.next == null)
            {
                return head;
            }
            while (curr != null)
            {
                if (curr.val < x)
                {
                    if (head.val >= x)
                    {
                        head = curr;
                    }
                    if (prevLessThan != null)
                    {
                        prevLessThan.next = curr;
                    }
                    prevLessThan = curr;
                }
                else
                {
                    if (firstGreater == null)
                    {
                        firstGreater = curr;
                    }
                    if (prev != null)
                    {
                        prev.next = curr;
                    }
                    prev = curr;
                }

                curr = curr.next;
            }

            //Fix pointer
            if (prev != null)
            {
                prev.next = null;
            }

            if (prevLessThan != null)
            {
                prevLessThan.next = firstGreater;
            }
            return head;
    }
}