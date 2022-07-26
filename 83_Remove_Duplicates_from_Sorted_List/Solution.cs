        public class Solution
        {
            public ListNode DeleteDuplicates(ListNode head)
            {
                ListNode curr = head;
                ListNode firstN = head;
                if (head == null || head.next == null)
                {
                    return head;
                }
                while (curr.next != null)
                {
                    if (curr.next.val != curr.val)
                    {
                        firstN.next = curr.next;
                        firstN = curr.next;
                    }
                    curr = curr.next;
                }

                firstN.next = null;

                return head;
            }
        }