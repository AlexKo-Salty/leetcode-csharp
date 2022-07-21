    public class Solution
    {
        //Iterative Method
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode prev = null;
            ListNode current = head;
            ListNode leftEnd = null;
            ListNode rightEnd = null;
            int count = 1;
            ListNode rightValue = null;
            ListNode leftValue = null;
            if (head.next == null || left == right)
            {
                return head;
            }
            while (count <= right)
            {
                if (count == left - 1)
                {
                    leftEnd = current;
                }

                if (count == right)
                {
                    rightValue = current;
                    rightEnd = current.next;
                }

                if (count == left)
                {
                    leftValue = current;
                }

                if (count >= left)
                {
                    ListNode next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
                count++;
            }

            if (leftValue != null)
            {
                leftValue.next = rightEnd;
            }
            if (leftEnd != null)
            {
                leftEnd.next = rightValue;
            }
            
            if (left == 1)
            {
                return prev;
            }
            else
            {
                return head;
            }
        }
    }
}