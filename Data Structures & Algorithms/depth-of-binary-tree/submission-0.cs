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
    // private int depth = 0;
    public int MaxDepth(TreeNode root) {
        return GetDepth(root, 0);
    }

    private int GetDepth(TreeNode curr, int depth)
    {
        if (curr == null)
            return depth;

        return Math.Max(GetDepth(curr.left, depth + 1), GetDepth(curr.right, depth + 1));
    }
}
