public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        Stack<TreeNode> s = new Stack<TreeNode>();
        TreeNode prev = null;

        int v1 = Math.Min(p.val, q.val);
        int v2 = Math.Max(p.val, q.val);

        s.Push(root);
        while (s.Count > 0)
        {
            TreeNode curr = s.Pop();
            if (curr.val <= v2 && curr.val > v1)
                return curr;

            if (curr.val == v1)
            {
                if (prev != null && prev.val <= v2)
                    return prev;
                else
                    return curr;
            }

            if (curr.right != null)
                s.Push(curr.right);
            if (curr.left != null)
                s.Push(curr.left);

            prev = curr;
        }

        return null;
    }

    //Recursive Method
    //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    //{
    //    if (root == null)
    //        return null;
    //    else if (root.val >= p.val && root.val <= q.val || root.val <= p.val && root.val >= q.val)
    //        return root;
    //    else if (root.val >= p.val)
    //        return LowestCommonAncestor(root.left, p, q);
    //    else
    //        return LowestCommonAncest
}