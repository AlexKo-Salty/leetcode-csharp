    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode current = stack.Pop();
                if (current != null)
                {
                    TreeNode leftTemp = current.left;
                    TreeNode rightTemp = current.right;
                    stack.Push(current.right);
                    stack.Push(current.left);

                    current.right = leftTemp;
                    current.left = rightTemp;
                }
            }

            return root;
        }
	}