        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode result = null;
            ListNode resultHead = null;
            while (list1 != null || list2 != null)
            {
                if (list2 == null)
                {
                    if (result == null)
                    {
                        resultHead = list1;
                    }
                    result = FillNext(result, list1);
                    list1 = list1.next;
                }
                else if (list1 == null)
                {
                    if (result == null)
                    {
                        resultHead = list2;
                    }
                    result = FillNext(result, list2);
                    list2 = list2.next;
                }
                else if (list1.val < list2.val)
                {
                    if (result == null)
                    {
                        resultHead = list1;
                    }
                    result = FillNext(result, list1);
                    list1 = list1.next;
                }
                else
                {
                    if (result == null)
                    {
                        resultHead = list2;
                    }
                    result = FillNext(result, list2);
                    list2 = list2.next;
                }
            }

            return resultHead;
        }

        public ListNode FillNext(ListNode target, ListNode next)
        {
            if (target == null)
            {
                target = next;
            }
            else
            {
                target.next = next;
                target = target.next;
            }
            return target;
        }