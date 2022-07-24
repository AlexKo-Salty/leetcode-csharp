        public class Solution
        {
            public ListNode DeleteDuplicates(ListNode head)
            {
                ListNode curr = head;
                ListNode headNoDuplicateNode = null;
                ListNode noDuplicateNode = null;
                bool isUnique = true;
                if (head == null || head.next == null)
                {
                    return head;
                }
                while (curr.next != null)
                {
                    if (curr.val == curr.next.val)
                    {
                        isUnique = false;
                    }
                    else
                    {
                        if (isUnique)
                        {
                            if (headNoDuplicateNode == null)
                            {
                                headNoDuplicateNode = curr;
                                noDuplicateNode = curr;
                            }
                            else
                            {
                                noDuplicateNode.next = curr;
                                noDuplicateNode = noDuplicateNode.next;
                            }
                        }
                        else
                        {
                            isUnique = true;
                        }
                    }
                    curr = curr.next;
                }

                if (isUnique)
                {
                    if (headNoDuplicateNode == null)
                    {
                        headNoDuplicateNode = curr;
                        headNoDuplicateNode.next = null;
                    }

                    if (noDuplicateNode != null)
                    {
                        noDuplicateNode.next = curr;
                        noDuplicateNode.next.next = null;
                    }
                }
                else
                {
                    if (noDuplicateNode != null)
                    {
                        noDuplicateNode.next = null;
                    }
                }
                return headNoDuplicateNode;
            }
        }