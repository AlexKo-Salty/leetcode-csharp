public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        if (root == null) { return true; }
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode Prev = null;
        while (root != null || stack.Count != 0)
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            root = stack.Pop();
            if (Prev != null && Prev.val >= root.val)
            {
                return false;
            }
            else
            {
                Prev = root;
            }
            root = root.right;
        }
        return true;
    }

    //Recursion
    //public bool IsValidBST(TreeNode root)
    //{
    //    return Helper(root, null,null);
    //}

    //public bool Helper(TreeNode node, int? left, int? right)
    //{
    //    if (node == null)
    //        return true;
    //    if (node.val >= right || node.val <= left)
    //        return false;

    //    return Helper(node.left, left, node.val) && Helper(node.right, node.val, right);
    //}

}