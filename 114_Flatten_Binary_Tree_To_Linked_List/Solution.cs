public class Solution {
        public void Flatten(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> list = new List<int>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode current = stack.Pop();
                if (current != null)
                {
                    list.Add(current.val);
                    stack.Push(current.right);
                    stack.Push(current.left);
                }
            }

            root.left = null;
            TreeNode curr = root;
            for (int i = 1; i < list.Count; i++)
            {
                curr.right = new TreeNode(list[i]);
                curr = curr.right;
            }

        }
}