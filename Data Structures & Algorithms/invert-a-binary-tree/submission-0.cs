/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        return SwitchChildren(root);
    }

    private TreeNode SwitchChildren(TreeNode curr)
    {
        if (curr == null)
            return null;

        TreeNode left = curr.left;

        curr.left = SwitchChildren(curr.right);
        curr.right = SwitchChildren(left);

        return curr;
    }
}
