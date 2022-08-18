public class Solution
{
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return Helper(nums, 0, nums.Length - 1);
    }

    private TreeNode Helper(int[] nums, int l, int r)
    {
        if (l > r)
            return null;

        int mid = l + (r - l) / 2;
        TreeNode root = new TreeNode(nums[mid]);
        root.left = Helper(nums, l, mid - 1);
        root.right = Helper(nums, mid + 1, r);
        return root;
    }
}