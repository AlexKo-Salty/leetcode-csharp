using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 2, 7, 1, 3, 6, 9 };
            Solution s = new Solution();
            //Create LinkedList
            ListNode head = null;
            for (int i = 1; i < nums.Length; i++)
            {
                head = s.CreateLinkedList(nums);
            }
            //Create Tree Root
            TreeNode root = new TreeNode(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                root = s.InsertRec(root, nums[i]);
            }
            s.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            Console.Read();
        }

        public class Solution
        {
            //Faster Solution by Sort the char to hashmap
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                List<IList<string>> result = new List<IList<string>>();
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
                for (int i = 0; i < strs.Length; i++)
                {
                    char[] charList = strs[i].ToCharArray();
                    Array.Sort(charList);
                    string sortedString = new string(charList);

                    if (dict.ContainsKey(sortedString))
                    {
                        dict[sortedString].Add(strs[i]);
                    }
                    else
                    {
                        dict.Add(sortedString, new List<string>() { strs[i] });
                    }
                }

                foreach (var r in dict)
                {
                    result.Add(r.Value);
                }

                return result;
            }

            //Too Slow
            //public IList<IList<string>> GroupAnagrams(string[] strs)
            //{
            //    Dictionary<string, int> paired = new Dictionary<string, int>();
            //    List<IList<string>> result = new List<IList<string>>();
            //    for (int i = 0; i < strs.Length; i++)
            //    {
            //        if (paired.ContainsKey(strs[i]))
            //            continue;
            //        List<string> currResult = new List<string>();
            //        currResult.Add(strs[i]);
            //        for (int j = i + 1; j < strs.Length; j++)
            //        {
            //            if(IsAnagram(strs[i], strs[j]))
            //            {
            //                if (!paired.ContainsKey(strs[i]))
            //                {
            //                    paired.Add(strs[i], 1);
            //                }
            //                if (!paired.ContainsKey(strs[j]))
            //                {
            //                    paired.Add(strs[j], 1);
            //                }
            //                currResult.Add(strs[j]);
            //            }
            //        }
            //        result.Add(currResult);
            //    }


            //    return result;
            //}

            //public bool IsAnagram(string s, string t)
            //{
            //    if (s.Length != t.Length)
            //        return false;
            //    Dictionary<char, int> dict = new Dictionary<char, int>(); 
            //    for (int i = 0; i < s.Length; i ++)
            //    {
            //        if (dict.ContainsKey(s[i]))
            //        {
            //            dict[s[i]]++;
            //        }
            //        else
            //        {
            //            dict.Add(s[i], 1);
            //        }
            //    }

            //    for (int j = 0; j < t.Length; j++)
            //    {
            //        if (!dict.ContainsKey(t[j]) || dict[t[j]] == 0)
            //            return false;
            //        else
            //            dict[t[j]]--;
            //    }

            //    return true;
            //}

            public ListNode CreateLinkedList(int[] nums)
            {
                ListNode head = new ListNode(nums[0]);
                ListNode curr = head;

                for (int i = 1; i < nums.Length; i++)
                {
                    curr.next = new ListNode(nums[i]);
                    curr = curr.next;
                }

                return head;
            }

            /* A recursive function to insert a new key in BST */
            public TreeNode InsertRec(TreeNode root, int val)
            {

                /* If the tree is empty, return a new node */
                if (root == null)
                {
                    root = new TreeNode(val);
                    return root;
                }

                /* Otherwise, recur down the tree */
                if (val < root.val)
                    root.left = InsertRec(root.left, val);
                else if (val > root.val)
                    root.right = InsertRec(root.right, val);

                /* return the (unchanged) node pointer */
                return root;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


    }
}
