public class Solution {
    public int GetDecimalValue(ListNode head) {
            string binary = "";
            while (head != null)
            {
                binary += head.val.ToString();
                head = head.next;
            }

            return Convert.ToInt32(binary, 2);
    }
}