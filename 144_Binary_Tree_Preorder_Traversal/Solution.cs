    public class Solution
    {
        //Iteratively Solution
        public IList<int> PreorderTraversal(TreeNode root)
        {
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

            return list;
        }

        //Recursive Solution
        //public IList<int> PreorderTraversal(TreeNode root)
        //{
        //    if (root == null)
        //    {
        //        return new List<int>();
        //    }
        //    Stack<int> vs = new Stack<int>();
        //    DFS(root, vs);
        //    int[] result = vs.ToArray();
        //    Array.Reverse(result);
        //    return result;
        //}

        //public Stack<int> DFS (TreeNode root, Stack<int> result)
        //{
        //    result.Push(root.val);
        //    if (root.left != null)
        //    {
        //        DFS(root.left, result);
        //    }

        //    if (root.right != null)
        //    {
        //        DFS(root.right, result);
        //    }

        //    return result;
        //}
	}