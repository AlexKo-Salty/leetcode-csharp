    public class Solution
    {
        //Recursive Method
        //Reference: https://www.geeksforgeeks.org/reverse-a-linked-list/
        public ListNode ReverseList(ListNode head)
        {
            if (head == null ||
               head.next == null)
                return head;

            ListNode rest = ReverseList(head.next);
            head.next.next = head;

            head.next = null;

            return rest;
        }

        //Iterative Method
        //Reference: https://www.youtube.com/watch?v=G0_I-ZF0S38
        //public ListNode ReverseList(ListNode head)
        //{
        //    ListNode prev = null;
        //    ListNode current = head;
        //    while (current != null)
        //    {
        //        ListNode next = current.next;
        //        current.next = prev;
        //        prev = current;
        //        current = next;
        //    }
        //    return prev;
        //}
    }
}