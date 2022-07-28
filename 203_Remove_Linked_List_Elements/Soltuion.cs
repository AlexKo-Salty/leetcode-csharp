public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
            ListNode prev = null;
            ListNode curr = head;
            if (head == null)
            {
                return head;
            }
            while (curr != null)
            {
                if (curr.val != val)
                {
                    if (prev != null)
                    {
                        prev.next = curr;
                    }
                    prev = curr;
                }
                else
                {
                    if (curr == head)
                    {
                        head = curr.next;
                    }
                    if (prev != null)
                    {
                        prev.next = null;
                    }    
                }

                curr = curr.next;
            }

            return head;
    }
}